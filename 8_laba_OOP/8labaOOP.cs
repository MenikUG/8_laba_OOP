using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _8_laba_OOP
{
	public partial class laba8 : Form
	{
		public laba8()
		{
			InitializeComponent();
			storag.AddObserver(tree);
		}

		public class Figure
		{   // Composite
			public int x, y;
			public Color color = Color.Navy;
			public Color fillcolor;
			public Figure() { }
			public virtual string save() { return ""; }
			public virtual void load(string x, string y, string c, string fillcolor) { }
			public virtual void load(ref StreamReader sr, Figure figure, CreateFigure createFigure) { }
			public virtual void GroupAddFigure(ref Figure object1) { }
			public virtual void UnGroup(ref Storage stg, int c) { }
			public virtual void paint_figure(Pen pen, Panel panel_drawing) { }
			public virtual void move_x(int x, Panel panel_drawing) { }
			public virtual void move_y(int y, Panel panel_drawing) { }
			public virtual void changesize(int size) { }
			public virtual bool checkfigure(int x, int y) { return false; }
			public virtual void setcolor(Color color) { }
			public virtual void caseswitch(ref StreamReader sr, ref Figure figure, CreateFigure createFigure) { }
			public virtual void get_min_x(ref int f) { }
			public virtual void get_max_x(ref int f) { }
			public virtual void get_min_y(ref int f) { }
			public virtual void get_max_y(ref int f) { }
			public virtual string name() { return "null"; }

		}
		class Group : Figure
		{   // Группа
			public int maxcount = 10;
			public Figure[] group;
			public int count;
			int min_x = 99999, max_x = 0, min_y = 99999, max_y = 0;
			public Group()
			{   // Выделяем maxcount мест в хранилище
				count = 0;
				group = new Figure[maxcount];
				for (int i = 0; i < maxcount; ++i)
					group[i] = null;
			}
			public override string save()
			{   // Функция сохранения
				string str = "Group" + "\n" + count;
				for (int i = 0; i < count; ++i)
					str += "\n" + group[i].save();
				return str;
			}
			public override void load(ref StreamReader sr, Figure figure, CreateFigure createFigure)
			{   // Функция загрузки
				int chislo = Convert.ToInt32(sr.ReadLine());
				for (int i = 0; i < chislo; ++i)
				{
					createFigure.caseswitch(ref sr, ref figure, createFigure);
					GroupAddFigure(ref figure);
				}
			}
			public override void GroupAddFigure(ref Figure object1)
			{   // Добавляет фигуру в группу
				if (count >= maxcount)
					return;
				group[count] = object1;
				++count;
			}
			public override void UnGroup(ref Storage stg, int c)
			{   // Разгруппировка
				stg.delete_object(c);
				for (int i = 0; i < count; ++i)
				{
					stg.add_object(index, ref group[i], k, ref indexin);
				}
			}
			public override void paint_figure(Pen pen, Panel panel_drawing)
			{   // Отображение группы
				for (int i = 0; i < count; ++i)
				{
					group[i].paint_figure(pen, panel_drawing);
				}
			}
			public void getsize()
			{
				min_x = 99999; max_x = 0; min_y = 99999; max_y = 0;
				for (int i = 0; i < count; ++i)
				{
					int f = 0;
					group[i].get_min_x(ref f);
					if (f < min_x)
						min_x = f;
					group[i].get_max_x(ref f);
					if (f > max_x)
						max_x = f;
					group[i].get_min_y(ref f);
					if (f < min_y)
						min_y = f;
					group[i].get_max_y(ref f);
					if (f > max_y)
						max_y = f;
				}
			}
			public override void move_x(int x, Panel panel_drawing)
			{   // Перемещение по оси x
				getsize();
				if ((min_x + x) > 0 && (max_x + x) < panel_drawing.ClientSize.Width)
				{
					for (int i = 0; i < count; ++i)
					{
						group[i].move_x(x, panel_drawing);
					}
				}
			}
			public override void get_min_x(ref int f)
			{
				f = min_x;
			}
			public override void get_max_x(ref int f)
			{
				f = max_x;
			}
			public override void get_min_y(ref int f)
			{
				f = min_y;
			}
			public override void get_max_y(ref int f)
			{
				f = max_y;
			}
			public override void move_y(int y, Panel panel_drawing)
			{   // Перемещение по оси y
				getsize();
				if ((min_y + y) > 0 && (max_y + y) < panel_drawing.ClientSize.Height)
				{
					for (int i = 0; i < count; ++i)
					{
						group[i].move_y(y, panel_drawing);
					}
				}
			}
			public override void changesize(int size)
			{   // Изменение размера
				for (int i = 0; i < count; ++i)
				{
					group[i].changesize(size);
				}
			}
			public override bool checkfigure(int x, int y)
			{   // Проверка на фигуры
				for (int i = 0; i < count; ++i)
				{
					if (group[i].checkfigure(x, y))
						return true;
				}
				return false;
			}
			public override void setcolor(Color color)
			{   // Установка цвета
				for (int i = 0; i < count; ++i)
				{
					group[i].setcolor(color);
				}
			}
            public override string name()
            {
                return "Group";
            }

        }
		class Circle : Figure
		{
			public int rad; // Радиус круга
			public Circle() { }
			public Circle(int x, int y, int rad)
			{
				this.rad = rad;
				this.x = x - rad;
				this.y = y - rad;
			}
			public override string save()
			{   // Функция сохранения
				return "Circle" + "\n" + x + "\n" + y + "\n" + rad + "\n" + fillcolor.ToArgb().ToString();
			}
			public override void load(string x, string y, string rad, string fillcolor)
			{   // Функция загрузки
				this.x = Convert.ToInt32(x);
				this.y = Convert.ToInt32(y);
				this.rad = Convert.ToInt32(rad);
				this.fillcolor = Color.FromArgb(Convert.ToInt32(fillcolor));
			}
			public override void paint_figure(Pen pen, Panel panel_drawing)
			{   // Отображение фигуры
				SolidBrush figurefillcolor = new SolidBrush(fillcolor);
				panel_drawing.CreateGraphics().DrawEllipse(
					pen, x, y, rad * 2, rad * 2);
				panel_drawing.CreateGraphics().FillEllipse(
					figurefillcolor, x, y, rad * 2, rad * 2);
			}
			public override void get_min_x(ref int f)
			{
				f = x;
			}
			public override void get_max_x(ref int f)
			{
				f = x + (rad * 2);
			}
			public override void get_min_y(ref int f)
			{
				f = y;
			}
			public override void get_max_y(ref int f)
			{
				f = y + (rad * 2);
			}
			public override void move_x(int x, Panel panel_drawing)
			{   // Перемещение по оси x
				int c = this.x + x;
				int gran = panel_drawing.ClientSize.Width - (rad * 2);
				check(c, x, gran, gran - 2, ref this.x);
			}
			public override void move_y(int y, Panel panel_drawing)
			{   // Перемещение по оси y
				int c = this.y + y;
				int gran = panel_drawing.ClientSize.Height - (rad * 2);
				check(c, y, gran, gran - 2, ref this.y);
			}
			public override void changesize(int size)
			{   // Изменение размера
				rad += size;
			}
			public override bool checkfigure(int x, int y)
			{   // Проверка на фигуры
				return ((x - this.x - rad) * (x - this.x - rad) + (y - this.y - rad) *
					(y - this.y - rad)) < (rad * rad);
			}
			public override void setcolor(Color color)
			{   // Установка цвета
				fillcolor = color;
			}
			public override string name()
			{
				return "Circle";
			}
		}
		class Line : Figure
		{
			public int lenght = 60;
			public int wight = 10;
			public Line() { }
			public Line(int x, int y)
			{
				this.x = x - lenght / 2;
				this.y = y;
			}
			public override string save()
			{   // Функция сохранения
				return "Line" + "\n" + x + "\n" + y + "\n" + lenght + "\n" + fillcolor.ToArgb().ToString();
			}
			public override void load(string x, string y, string lenght, string fillcolor)
			{   // Функция загрузки
				this.x = Convert.ToInt32(x);
				this.y = Convert.ToInt32(y);
				this.lenght = Convert.ToInt32(lenght);
				this.fillcolor = Color.FromArgb(Convert.ToInt32(fillcolor));
			}
			public override void paint_figure(Pen pen, Panel panel_drawing)
			{   // Отображение фигуры
				SolidBrush figurefillcolor = new SolidBrush(fillcolor);
				panel_drawing.CreateGraphics().DrawRectangle(pen, x,
										y, lenght, wight);
				panel_drawing.CreateGraphics().FillRectangle(figurefillcolor, x,
					y, lenght, wight);
			}
			public override void get_min_x(ref int f)
			{
				f = x;
			}
			public override void get_max_x(ref int f)
			{
				f = x + lenght;
			}
			public override void get_min_y(ref int f)
			{
				f = y;
			}
			public override void get_max_y(ref int f)
			{
				f = y + wight;
			}
			public override void move_x(int x, Panel panel_drawing)
			{   // Перемещение по оси x
				int l = this.x + x;
				int gran = panel_drawing.ClientSize.Width - lenght;
				check(l, x, gran, --gran, ref this.x);
			}
			public override void move_y(int y, Panel panel_drawing)
			{   // Перемещение по оси y
				int l = this.y + y;
				int gran = panel_drawing.ClientSize.Height - wight;
				check(l, y, gran, --gran, ref this.y);
			}
			public override void changesize(int size)
			{   // Изменение размера
				lenght += size;
			}
			public override bool checkfigure(int x, int y)
			{   // Проверка на фигуры
				return (this.x <= x && x <= (this.x + lenght) && (this.y - 2) <= y &&
									y <= (this.y + wight));
			}
			public override void setcolor(Color color)
			{   // Установка цвета
				fillcolor = color;
			}
			public override string name()
			{
				return "Line";
			}
		}
		class Square : Figure
		{
			public int size = 60;
			public Square() { }
			public Square(int x, int y)
			{
				this.x = x - size / 2;
				this.y = y - size / 2;
			}
			public override string save()
			{   // Функция сохранения
				return "Square" + "\n" + x + "\n" + y + "\n" + size + "\n" + fillcolor.ToArgb().ToString();
			}
			public override void load(string x, string y, string size, string fillcolor)
			{   // Функция загрузки
				this.x = Convert.ToInt32(x);
				this.y = Convert.ToInt32(y);
				this.size = Convert.ToInt32(size);
				this.fillcolor = Color.FromArgb(Convert.ToInt32(fillcolor));
			}
			public override void paint_figure(Pen pen, Panel panel_drawing)
			{   // Отображение фигуры
				SolidBrush figurefillcolor = new SolidBrush(fillcolor);
				panel_drawing.CreateGraphics().DrawRectangle(pen,
					x, y, size, size);
				panel_drawing.CreateGraphics().FillRectangle(figurefillcolor,
					x, y, size, size);
			}
			public override void get_min_x(ref int f)
			{
				f = x;
			}
			public override void get_max_x(ref int f)
			{
				f = x + size;
			}
			public override void get_min_y(ref int f)
			{
				f = y;
			}
			public override void get_max_y(ref int f)
			{
				f = y + size;
			}
			public override void move_x(int x, Panel panel_drawing)
			{   // Перемещение по оси x
				int s = this.x + x;
				int gran = panel_drawing.ClientSize.Width - size;
				check(s, x, gran, --gran, ref this.x);
			}
			public override void move_y(int y, Panel panel_drawing)
			{   // Перемещение по оси y
				int s = this.y + y;
				int gran = panel_drawing.ClientSize.Height - size;
				check(s, y, gran, --gran, ref this.y);
			}
			public override void changesize(int size)
			{   // Изменение размера
				this.size += size;
			}
			public override bool checkfigure(int x, int y)
			{   // Проверка на фигуры
				return (this.x <= x && x <= (this.x + size) &&
										this.y <= y && y <= (this.y + size));
			}
			public override void setcolor(Color color)
			{   // Установка цвета
				fillcolor = color;
			}
			public override string name()
			{
				return "Square";
			}
		}
		public class CreateFigure : Figure
		{   // Используем Factory Method
			public override void caseswitch(ref StreamReader sr, ref Figure figure, CreateFigure createFigure)
			{
				string str = sr.ReadLine();
				switch (str)
				{   // В зависимости какая фигура выбрана
					case "Circle":
						figure = new Circle();
						figure.load(sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine());
						break;
					case "Line":
						figure = new Line();
						figure.load(sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine());
						break;
					case "Square":
						figure = new Square();
						figure.load(sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine());
						break;
					case "Group":
						figure = new Group();
						figure.load(ref sr, figure, createFigure);
						break;
				}
			}
		}

		static public void check(int f, int chislo, int gran, int gran1, ref int x)
		{   // Проверка на выход фигуры за границы
			if (f > 0 && f < gran)
				x += chislo;
			else
			{
				if (f <= 0)
					x = 1;
				else
					if (f >= gran1)
					x = gran1;
			}
		}

		TreeViews tree = new TreeViews();
		int p = 0; // Нажат ли был ранее Ctrl
		static int k = 15; // Кол-во ячеек в хранилище
		Storage storag = new Storage(k); // Создаем объект хранилища
		static int index = 0; // Кол-во нарисованных фигур
		static int indexin = 0; // Индекс, в какое место была помещена фигура
		int figure_now = 1; // Какая фигура выбрана		
		public interface IObservable
		{   // Наблюдаемый объект
			void AddObserver(IObserver o);
			void RemoveObserver(IObserver o);
			void NotifyObservers();
		}
		public interface IObserver
		{   // Наблюдатель
			void Update(ref TreeView treeView, Storage stg);
		}
		public class Storage: IObservable
		{
			public Figure[] objects;
			public TreeView treeView;
			public List<IObserver> observers;
			public Storage() { }
			public Storage(int count)
			{   // Выделяем count мест в хранилище
				objects = new Figure[count];
				observers = new List<IObserver>();
				for (int i = 0; i < count; ++i)
					objects[i] = null;
			}
			public void intit_tree(ref TreeView treeView)
            {
				this.treeView = treeView;
			}
			public void initialisat(int count)
			{   // Выделяем count мест в хранилище
				objects = new Figure[count];
				for (int i = 0; i < count; ++i)
					objects[i] = null;
			}
			public void add_object(int ind, ref Figure object1, int count, ref int indexin)
			{   // Добавляет ячейку в хранилище
				// Если ячейка занята ищем свободное место
				while (objects[ind] != null)
				{
					ind = (ind + 1) % count;
				}
				objects[ind] = object1;
				indexin = ind;
				sorting(k);
				NotifyObservers();
			}
			public void delete_object(int ind)
			{   // Удаляет объект из хранилища
				objects[ind] = null;
				if (index > 0)
					index--;
				NotifyObservers();
			}
			public bool check_empty(int index)
			{   // Проверяет занято ли место хранилище
				if (objects[index] == null)
					return true;
				else return false;
			}
			public int occupied(int size)
			{ // Определяет кол-во занятых мест в хранилище
				int count_occupied = 0;
				for (int i = 0; i < size; ++i)
					if (!check_empty(i))
						++count_occupied;
				return count_occupied;
			}
			public void doubleSize(ref int size)
			{   // Функция для увеличения кол-ва элементов в хранилище в 2 раза 
				Storage storage1 = new Storage(size * 2);
				for (int i = 0; i < size; ++i)
					storage1.objects[i] = objects[i];
				for (int i = size; i < (size * 2) - 1; ++i)
					storage1.objects[i] = null;
				size = size * 2;
				initialisat(size);
				for (int i = 0; i < size; ++i)
					objects[i] = storage1.objects[i];
			}			
			public void AddObserver(IObserver o)
			{
				observers.Add(o);
			}
			public void RemoveObserver(IObserver o)
			{
				observers.Remove(o);
			}
			public void NotifyObservers()
			{				
				foreach (IObserver observer in observers)
					observer.Update(ref treeView, this);
			}
			public void sorting(int size)
            {
				Storage storage1 = new Storage(size);
				int col = 0;
				for (int i = 0; i < size; ++i)
				{
					if (!check_empty(i)) 
					{
						storage1.objects[col] = objects[i];
						++col;
					}
				}
				initialisat(size);
				for (int i = 0; i < size; ++i)
					objects[i] = storage1.objects[i];
			}
		}
		class TreeViews : IObserver
		{
			public TreeViews() { }
			public void Update(ref TreeView treeView, Storage stg)
			{
				treeView.Nodes.Clear();
				treeView.Nodes.Add("Фигуры");
				for(int i = 0; i < k; ++i)
                {
					if (!stg.check_empty(i))
					{
						fillnode(treeView.Nodes[0], stg.objects[i]);
					}
                }
				treeView.ExpandAll();			
			}
			public void treeSelect(ref TreeView treeView, int index) //выбор узла
			{
				treeView.SelectedNode = treeView.Nodes[0].Nodes[index];
				treeView.Focus();
			}
			public void fillnode(TreeNode treeNode, Figure figure)
            {
				TreeNode nodes = treeNode.Nodes.Add(figure.name());
				if(figure.name() == "Group")
                {
					for(int i = 0; i < (figure as Group).count; ++i)
                    {
						fillnode(nodes, (figure as Group).group[i]);
                    }
                }
            }
			
		}
		private void panel_drawing_MouseClick(object sender, MouseEventArgs e)
		{
			//Проверка на наличие фигуры на данных координатах
			int c = check_figure(ref storag, k, e.X, e.Y);
			storag.intit_tree(ref treeView1);
			if (c != -1)
			{   // Если на этом месте уже нарисована фигура
				if (Control.ModifierKeys == Keys.Control)
				{   // Если нажат ctrl, то выделяем несколько объектов
					if (p == 0)
					{
						paint_figure(Color.Navy, 4, ref storag, indexin);
						p = 1;
					}
					// Вызываем функцию отрисовки фигуры  
					paint_figure(Color.Red, 4, ref storag, c);
				}
				else
				{   // Иначе выделяем только один объект
					// Снимаем выделение у всех объектов хранилища
					remove_selection_circle(ref storag);
					paint_figure(Color.Red, 4, ref storag, c);
					tree.treeSelect(ref treeView1, c);
				}
				return;
			}
			Figure figure = new Figure();
			switch (figure_now)
			{   // В зависимости какая фигура выбрана
				case 0:
					return;
				case 1:
					figure = new Circle(e.X, e.Y, 30);
					break;
				case 2:
					figure = new Line(e.X, e.Y);
					break;
				case 3:
					figure = new Square(e.X, e.Y);
					break;
			}
			if (index == k)
				storag.doubleSize(ref k);
			// Добавляем фигуру в хранилище   
			storag.add_object(index, ref figure, k, ref indexin);
			// Снимаем выделение у всех объектов хранилища
			remove_selection_circle(ref storag);
			storag.objects[indexin].fillcolor = colorDialog1.Color;
			paint_figure(Color.Red, 4, ref storag, indexin);
			++index;
			p = 0;
		}
		private void remove_selection_circle(ref Storage stg)
		{   // Снимает выделение у всех элементов хранилища
			for (int i = 0; i < k; ++i)
			{
				if (!stg.check_empty(i))
				{   // Вызываем функцию отрисовки круга
					paint_figure(Color.Navy, 4, ref storag, i);
				}
			}
		}
		private void move_y(ref Storage stg, int y)
		{   // Функция для перемещения фигур по оси Y
			for (int i = 0; i < k; ++i)
			{
				if (!stg.check_empty(i))
				{
					if (stg.objects[i].color == Color.Red)
					{   // Если объект выделен
						stg.objects[i].move_y(y, panel_drawing);
					}
				}
			}
		}
		private void move_x(ref Storage stg, int x)
		{   // Функция для перемещения фигур по оси X
			for (int i = 0; i < k; ++i)
			{
				if (!stg.check_empty(i))
				{
					if (stg.objects[i].color == Color.Red)
					{   // Если объект выделен
						stg.objects[i].move_x(x, panel_drawing);
					}
				}
			}
		}
		private void changesize(ref Storage stg, int size)
		{   // Увеличивает или уменьшает размер фигур, в зависимости от size
			for (int i = 0; i < k; ++i)
			{
				if (!stg.check_empty(i))
				{   // Если под i индексом в хранилище есть объект
					if (stg.objects[i].color == Color.Red)
					{
						stg.objects[i].changesize(size);
					}
				}
			}
		}
		private void remove_selected_circle(ref Storage stg)
		{   // Удаляет выделенные элементы из хранилища
			for (int i = 0; i < k; ++i)
			{
				if (!stg.check_empty(i))
				{
					if (stg.objects[i].color == Color.Red)
						stg.delete_object(i);
				}
			}
		}
		private void Clear_Click(object sender, EventArgs e)
		{   // Очистка хранилища и панели
			for (int i = 0; i < k; ++i)
			{
				if (!storag.check_empty(i))
				{
					storag.delete_object(i);
				}
			}
			panel_drawing.Refresh();
		}
		private void paint_figure(Color name, int size, ref Storage stg, int index)
		{   // Рисует фигуру на панели          
			// Объявляем объект - карандаш, которым будем рисовать контур
			if (!stg.check_empty(index))
			{
				Pen pen = new Pen(name, size);
				stg.objects[index].color = name;
				stg.objects[index].paint_figure(pen, panel_drawing);
			}
		}
		private void paint_all(ref Storage stg)
		{   // Рисует все фигуры на панели
			for (int i = 0; i < k; ++i)
				if (!stg.check_empty(i))
					paint_figure(stg.objects[i].color, 4, ref storag, i);
		}
		private int check_figure(ref Storage stg, int size, int x, int y)
		{   // Проверяет есть ли уже фигура с такими же координатами в хранилище
			if (stg.occupied(size) != 0)
			{
				for (int i = 0; i < size; ++i)
				{
					if (!stg.check_empty(i))
					{   // Если под i индексом в хранилище есть объект
						if (stg.objects[i].checkfigure(x, y))
							return i;
					}
				}
			}
			return -1;
		}
		private void drawellipse_Click(object sender, EventArgs e)
		{
			drawline.Checked = false;
			drawsquare.Checked = false;
			figure_now = 1;
			if (drawellipse.Checked == false) // Если не выбрана фигура
				figure_now = 0;
		}
		private void drawline_Click(object sender, EventArgs e)
		{
			drawsquare.Checked = false;
			drawellipse.Checked = false;
			figure_now = 2;
			if (drawline.Checked == false) // Если не выбрана фигура
				figure_now = 0;
		}
		private void drawsquare_Click(object sender, EventArgs e)
		{
			drawline.Checked = false;
			drawellipse.Checked = false;
			figure_now = 3;
			if (drawsquare.Checked == false) // Если не выбрана фигура
				figure_now = 0;
		}
		private void laba8_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{   // Удаление выделенных фигур, если нажата кнопка delete
				remove_selected_circle(ref storag);
			}
			if (e.KeyCode == Keys.W)
			{   // Перемещение по оси X вверх
				move_y(ref storag, -10);
			}
			if (e.KeyCode == Keys.S)
			{   // Перемещение по оси X вниз
				move_y(ref storag, +10);
			}
			if (e.KeyCode == Keys.A)
			{   // Перемещение по оси Y вниз
				move_x(ref storag, -10);
			}
			if (e.KeyCode == Keys.D)
			{   // Перемещение по оси Y вверх
				move_x(ref storag, +10);
			}
			if (e.KeyCode == Keys.Oemplus)
			{   // Увеличиваем размер фигуры
				changesize(ref storag, 10);
			}
			if (e.KeyCode == Keys.OemMinus)
			{   // Уменьшаем размер фигуры
				changesize(ref storag, -10);
			}
			panel_drawing.Refresh();
			paint_all(ref storag);
		}
		private void btn_select_color_Click(object sender, EventArgs e)
		{   // Смена цвета у фигур
			if (colorDialog1.ShowDialog() == DialogResult.Cancel)
				return;
			btn_select_color.BackColor = colorDialog1.Color;
			for (int i = 0; i < k; ++i)
			{
				if (!storag.check_empty(i))
					if (storag.objects[i].color == Color.Red)
					{
						storag.objects[i].setcolor(colorDialog1.Color);
						paint_figure(storag.objects[i].color, 4, ref storag, i);
					}
			}
		}
		private void btn_group_Click(object sender, EventArgs e)
		{   // Создаём группу из выделенных фигур
			Figure group = new Group();
			for (int i = 0; i < k; ++i)
			{
				if (!storag.check_empty(i))
					if (storag.objects[i].color == Color.Red)
					{
						group.GroupAddFigure(ref storag.objects[i]);
						storag.delete_object(i);
					}
			}
			storag.add_object(index, ref group, k, ref indexin);
		}
		private void btn_ungroup_Click(object sender, EventArgs e)
		{   // Разгруппировка группы
			for (int i = 0; i < k; ++i)
			{
				if (!storag.check_empty(i))
					if (storag.objects[i].color == Color.Red)
					{
						storag.objects[i].UnGroup(ref storag, i);
						return;
					}
			}
		}
		string path = @"D:\Projects\7_laba_OOP\7_laba_OOP\File.txt";
		private void btn_save_Click(object sender, EventArgs e)
		{   // Сохраяем хранилище в файл
			using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
			{
				sw.WriteLine(storag.occupied(k));
				for (int i = 0; i < k; ++i)
				{
					if (!storag.check_empty(i))
					{
						sw.WriteLine(storag.objects[i].save());
					}
				}
			}
		}
		private void btn_load_Click(object sender, EventArgs e)
		{   // Загружаем данные из файла
			StreamReader sr = new StreamReader(path, System.Text.Encoding.Default);
			{
				string str = sr.ReadLine();
				int strend = Convert.ToInt32(str);
				for (int i = 0; i < strend; ++i)
				{
					Figure figure = new Figure();
					CreateFigure create = new CreateFigure();
					create.caseswitch(ref sr, ref figure, create);
					if (index == k)
						storag.doubleSize(ref k);
					storag.add_object(index, ref figure, k, ref indexin);
					++index;
				}
				paint_all(ref storag);
				sr.Close();
			}
		}
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
			remove_selection_circle(ref storag);
            int g;
            if (e.Node.Level != 1)
            {
                g = e.Node.Parent.Index;
            }
            else
            {
                g = e.Node.Index;
            }
            paint_figure(Color.Red, 4, ref storag, g);
        }
    }
}