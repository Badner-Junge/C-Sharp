
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action svsdrrAction;

	private global::Gtk.Action dsvsrAction;

	private global::Gtk.Action DateiAction;

	private global::Gtk.Action HilfeAction;

	private global::Gtk.Action BeendenAction;

	private global::Gtk.VBox main_Layout_horizontal;

	private global::Gtk.MenuBar menubar;

	private global::Gtk.Notebook main_Tabs;

	private global::Gtk.HBox hbox7;

	private global::Gtk.VButtonBox vbuttonbox7;

	private global::Gtk.Button button28;

	private global::Gtk.Button button29;

	private global::Gtk.Button button30;

	private global::Gtk.Button button31;

	private global::Gtk.Button button32;

	private global::Gtk.Label overview;

	private global::Gtk.HBox hbox4;

	private global::Gtk.VButtonBox vbuttonbox4;

	private global::Gtk.Button button18;

	private global::Gtk.Button button19;

	private global::Gtk.Button button20;

	private global::Gtk.Button button21;

	private global::Gtk.Button button22;

	private global::Gtk.Label todo;

	private global::Gtk.HBox hbox8;

	private global::Gtk.Notebook notebook8;

	private global::Gtk.Label label18;

	private global::Gtk.Label label20;

	private global::Gtk.Label label21;

	private global::Gtk.Label label22;

	private global::Gtk.VButtonBox vbuttonbox6;

	private global::Gtk.Button button23;

	private global::Gtk.Button button24;

	private global::Gtk.Button button25;

	private global::Gtk.Button button26;

	private global::Gtk.Button button27;

	private global::Gtk.Label children;

	private global::Gtk.HBox hbox5;

	private global::Gtk.Calendar calendar6;

	private global::Gtk.VButtonBox vbuttonbox5;

	private global::Gtk.Button button13;

	private global::Gtk.Button button14;

	private global::Gtk.Button button15;

	private global::Gtk.Button button16;

	private global::Gtk.Button button17;

	private global::Gtk.Label calendar;

	private global::Gtk.HBox hbox6;

	private global::Gtk.VButtonBox vbuttonbox3;

	private global::Gtk.Button button8;

	private global::Gtk.Button button9;

	private global::Gtk.Button button10;

	private global::Gtk.Button button11;

	private global::Gtk.Button button12;

	private global::Gtk.Label shoppinglist;

	private global::Gtk.HBox hbox3;

	private global::Gtk.ScrolledWindow GtkScrolledWindow1;

	private global::Gtk.TreeView treeview2;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TextView textview1;

	private global::Gtk.VButtonBox vbuttonbox2;

	private global::Gtk.Button button3;

	private global::Gtk.Button button4;

	private global::Gtk.Button button5;

	private global::Gtk.Button button6;

	private global::Gtk.Button button7;

	private global::Gtk.Label recipes;

	private global::Gtk.HBox hbox10;

	private global::Gtk.VButtonBox vbuttonbox8;

	private global::Gtk.Button button33;

	private global::Gtk.Button button34;

	private global::Gtk.Button button35;

	private global::Gtk.Button button36;

	private global::Gtk.Button button37;

	private global::Gtk.Label meal;

	private global::Gtk.HBox hbox9;

	private global::Gtk.Label household;

	private global::Gtk.Statusbar statusbar;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.svsdrrAction = new global::Gtk.Action("svsdrrAction", global::Mono.Unix.Catalog.GetString("svsdrr"), null, null);
		this.svsdrrAction.ShortLabel = global::Mono.Unix.Catalog.GetString("svsdrr");
		w1.Add(this.svsdrrAction, null);
		this.dsvsrAction = new global::Gtk.Action("dsvsrAction", global::Mono.Unix.Catalog.GetString("dsvsr"), null, null);
		this.dsvsrAction.ShortLabel = global::Mono.Unix.Catalog.GetString("dsvsr");
		w1.Add(this.dsvsrAction, null);
		this.DateiAction = new global::Gtk.Action("DateiAction", global::Mono.Unix.Catalog.GetString("Datei"), null, null);
		this.DateiAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Datei");
		w1.Add(this.DateiAction, null);
		this.HilfeAction = new global::Gtk.Action("HilfeAction", global::Mono.Unix.Catalog.GetString("Hilfe"), null, null);
		this.HilfeAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Hilfe");
		w1.Add(this.HilfeAction, null);
		this.BeendenAction = new global::Gtk.Action("BeendenAction", global::Mono.Unix.Catalog.GetString("Beenden"), null, null);
		this.BeendenAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Beenden");
		w1.Add(this.BeendenAction, null);
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.WidthRequest = 1024;
		this.HeightRequest = 600;
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.main_Layout_horizontal = new global::Gtk.VBox();
		this.main_Layout_horizontal.Name = "main_Layout_horizontal";
		this.main_Layout_horizontal.Spacing = 6;
		// Container child main_Layout_horizontal.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString("<ui><menubar name=\'menubar\'><menu name=\'DateiAction\' action=\'DateiAction\'><menuit" +
				"em name=\'BeendenAction\' action=\'BeendenAction\'/></menu><menu name=\'HilfeAction\' " +
				"action=\'HilfeAction\'/></menubar></ui>");
		this.menubar = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar")));
		this.menubar.Name = "menubar";
		this.main_Layout_horizontal.Add(this.menubar);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.main_Layout_horizontal[this.menubar]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child main_Layout_horizontal.Gtk.Box+BoxChild
		this.main_Tabs = new global::Gtk.Notebook();
		this.main_Tabs.CanFocus = true;
		this.main_Tabs.Name = "main_Tabs";
		this.main_Tabs.CurrentPage = 5;
		this.main_Tabs.TabPos = ((global::Gtk.PositionType)(0));
		// Container child main_Tabs.Gtk.Notebook+NotebookChild
		this.hbox7 = new global::Gtk.HBox();
		this.hbox7.Name = "hbox7";
		this.hbox7.Spacing = 6;
		// Container child hbox7.Gtk.Box+BoxChild
		this.vbuttonbox7 = new global::Gtk.VButtonBox();
		this.vbuttonbox7.Name = "vbuttonbox7";
		this.vbuttonbox7.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(3));
		// Container child vbuttonbox7.Gtk.ButtonBox+ButtonBoxChild
		this.button28 = new global::Gtk.Button();
		this.button28.HeightRequest = 109;
		this.button28.CanFocus = true;
		this.button28.Name = "button28";
		this.button28.UseUnderline = true;
		this.button28.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox7.Add(this.button28);
		global::Gtk.ButtonBox.ButtonBoxChild w3 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox7[this.button28]));
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbuttonbox7.Gtk.ButtonBox+ButtonBoxChild
		this.button29 = new global::Gtk.Button();
		this.button29.CanFocus = true;
		this.button29.Name = "button29";
		this.button29.UseUnderline = true;
		this.button29.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox7.Add(this.button29);
		global::Gtk.ButtonBox.ButtonBoxChild w4 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox7[this.button29]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbuttonbox7.Gtk.ButtonBox+ButtonBoxChild
		this.button30 = new global::Gtk.Button();
		this.button30.CanFocus = true;
		this.button30.Name = "button30";
		this.button30.UseUnderline = true;
		this.button30.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox7.Add(this.button30);
		global::Gtk.ButtonBox.ButtonBoxChild w5 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox7[this.button30]));
		w5.Position = 2;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbuttonbox7.Gtk.ButtonBox+ButtonBoxChild
		this.button31 = new global::Gtk.Button();
		this.button31.CanFocus = true;
		this.button31.Name = "button31";
		this.button31.UseUnderline = true;
		this.button31.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox7.Add(this.button31);
		global::Gtk.ButtonBox.ButtonBoxChild w6 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox7[this.button31]));
		w6.Position = 3;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbuttonbox7.Gtk.ButtonBox+ButtonBoxChild
		this.button32 = new global::Gtk.Button();
		this.button32.CanFocus = true;
		this.button32.Name = "button32";
		this.button32.UseUnderline = true;
		this.button32.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox7.Add(this.button32);
		global::Gtk.ButtonBox.ButtonBoxChild w7 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox7[this.button32]));
		w7.Position = 4;
		w7.Expand = false;
		w7.Fill = false;
		this.hbox7.Add(this.vbuttonbox7);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.vbuttonbox7]));
		w8.Position = 2;
		w8.Expand = false;
		w8.Fill = false;
		this.main_Tabs.Add(this.hbox7);
		// Notebook tab
		this.overview = new global::Gtk.Label();
		this.overview.CanDefault = true;
		this.overview.CanFocus = true;
		this.overview.Name = "overview";
		this.overview.LabelProp = global::Mono.Unix.Catalog.GetString("Übersicht");
		this.main_Tabs.SetTabLabel(this.hbox7, this.overview);
		this.overview.ShowAll();
		// Container child main_Tabs.Gtk.Notebook+NotebookChild
		this.hbox4 = new global::Gtk.HBox();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.vbuttonbox4 = new global::Gtk.VButtonBox();
		this.vbuttonbox4.Name = "vbuttonbox4";
		this.vbuttonbox4.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(3));
		// Container child vbuttonbox4.Gtk.ButtonBox+ButtonBoxChild
		this.button18 = new global::Gtk.Button();
		this.button18.HeightRequest = 109;
		this.button18.CanFocus = true;
		this.button18.Name = "button18";
		this.button18.UseUnderline = true;
		this.button18.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox4.Add(this.button18);
		global::Gtk.ButtonBox.ButtonBoxChild w10 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox4[this.button18]));
		w10.Expand = false;
		w10.Fill = false;
		// Container child vbuttonbox4.Gtk.ButtonBox+ButtonBoxChild
		this.button19 = new global::Gtk.Button();
		this.button19.CanFocus = true;
		this.button19.Name = "button19";
		this.button19.UseUnderline = true;
		this.button19.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox4.Add(this.button19);
		global::Gtk.ButtonBox.ButtonBoxChild w11 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox4[this.button19]));
		w11.Position = 1;
		w11.Expand = false;
		w11.Fill = false;
		// Container child vbuttonbox4.Gtk.ButtonBox+ButtonBoxChild
		this.button20 = new global::Gtk.Button();
		this.button20.CanFocus = true;
		this.button20.Name = "button20";
		this.button20.UseUnderline = true;
		this.button20.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox4.Add(this.button20);
		global::Gtk.ButtonBox.ButtonBoxChild w12 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox4[this.button20]));
		w12.Position = 2;
		w12.Expand = false;
		w12.Fill = false;
		// Container child vbuttonbox4.Gtk.ButtonBox+ButtonBoxChild
		this.button21 = new global::Gtk.Button();
		this.button21.CanFocus = true;
		this.button21.Name = "button21";
		this.button21.UseUnderline = true;
		this.button21.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox4.Add(this.button21);
		global::Gtk.ButtonBox.ButtonBoxChild w13 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox4[this.button21]));
		w13.Position = 3;
		w13.Expand = false;
		w13.Fill = false;
		// Container child vbuttonbox4.Gtk.ButtonBox+ButtonBoxChild
		this.button22 = new global::Gtk.Button();
		this.button22.CanFocus = true;
		this.button22.Name = "button22";
		this.button22.UseUnderline = true;
		this.button22.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox4.Add(this.button22);
		global::Gtk.ButtonBox.ButtonBoxChild w14 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox4[this.button22]));
		w14.Position = 4;
		w14.Expand = false;
		w14.Fill = false;
		this.hbox4.Add(this.vbuttonbox4);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vbuttonbox4]));
		w15.Position = 2;
		w15.Expand = false;
		w15.Fill = false;
		this.main_Tabs.Add(this.hbox4);
		global::Gtk.Notebook.NotebookChild w16 = ((global::Gtk.Notebook.NotebookChild)(this.main_Tabs[this.hbox4]));
		w16.Position = 1;
		// Notebook tab
		this.todo = new global::Gtk.Label();
		this.todo.Name = "todo";
		this.todo.LabelProp = global::Mono.Unix.Catalog.GetString("To Do");
		this.main_Tabs.SetTabLabel(this.hbox4, this.todo);
		this.todo.ShowAll();
		// Container child main_Tabs.Gtk.Notebook+NotebookChild
		this.hbox8 = new global::Gtk.HBox();
		this.hbox8.Name = "hbox8";
		this.hbox8.Spacing = 6;
		// Container child hbox8.Gtk.Box+BoxChild
		this.notebook8 = new global::Gtk.Notebook();
		this.notebook8.CanFocus = true;
		this.notebook8.Name = "notebook8";
		this.notebook8.CurrentPage = 3;
		// Notebook tab
		global::Gtk.Label w17 = new global::Gtk.Label();
		w17.Visible = true;
		this.notebook8.Add(w17);
		this.label18 = new global::Gtk.Label();
		this.label18.Name = "label18";
		this.label18.LabelProp = global::Mono.Unix.Catalog.GetString("page1");
		this.notebook8.SetTabLabel(w17, this.label18);
		this.label18.ShowAll();
		// Notebook tab
		global::Gtk.Label w18 = new global::Gtk.Label();
		w18.Visible = true;
		this.notebook8.Add(w18);
		this.label20 = new global::Gtk.Label();
		this.label20.Name = "label20";
		this.label20.LabelProp = global::Mono.Unix.Catalog.GetString("page2");
		this.notebook8.SetTabLabel(w18, this.label20);
		this.label20.ShowAll();
		// Notebook tab
		global::Gtk.Label w19 = new global::Gtk.Label();
		w19.Visible = true;
		this.notebook8.Add(w19);
		this.label21 = new global::Gtk.Label();
		this.label21.Name = "label21";
		this.label21.LabelProp = global::Mono.Unix.Catalog.GetString("page3");
		this.notebook8.SetTabLabel(w19, this.label21);
		this.label21.ShowAll();
		// Notebook tab
		global::Gtk.Label w20 = new global::Gtk.Label();
		w20.Visible = true;
		this.notebook8.Add(w20);
		this.label22 = new global::Gtk.Label();
		this.label22.Name = "label22";
		this.label22.LabelProp = global::Mono.Unix.Catalog.GetString("page4");
		this.notebook8.SetTabLabel(w20, this.label22);
		this.label22.ShowAll();
		this.hbox8.Add(this.notebook8);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.notebook8]));
		w21.Position = 0;
		// Container child hbox8.Gtk.Box+BoxChild
		this.vbuttonbox6 = new global::Gtk.VButtonBox();
		this.vbuttonbox6.Name = "vbuttonbox6";
		this.vbuttonbox6.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(3));
		// Container child vbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
		this.button23 = new global::Gtk.Button();
		this.button23.HeightRequest = 109;
		this.button23.CanFocus = true;
		this.button23.Name = "button23";
		this.button23.UseUnderline = true;
		this.button23.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox6.Add(this.button23);
		global::Gtk.ButtonBox.ButtonBoxChild w22 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox6[this.button23]));
		w22.Expand = false;
		w22.Fill = false;
		// Container child vbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
		this.button24 = new global::Gtk.Button();
		this.button24.CanFocus = true;
		this.button24.Name = "button24";
		this.button24.UseUnderline = true;
		this.button24.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox6.Add(this.button24);
		global::Gtk.ButtonBox.ButtonBoxChild w23 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox6[this.button24]));
		w23.Position = 1;
		w23.Expand = false;
		w23.Fill = false;
		// Container child vbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
		this.button25 = new global::Gtk.Button();
		this.button25.CanFocus = true;
		this.button25.Name = "button25";
		this.button25.UseUnderline = true;
		this.button25.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox6.Add(this.button25);
		global::Gtk.ButtonBox.ButtonBoxChild w24 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox6[this.button25]));
		w24.Position = 2;
		w24.Expand = false;
		w24.Fill = false;
		// Container child vbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
		this.button26 = new global::Gtk.Button();
		this.button26.CanFocus = true;
		this.button26.Name = "button26";
		this.button26.UseUnderline = true;
		this.button26.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox6.Add(this.button26);
		global::Gtk.ButtonBox.ButtonBoxChild w25 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox6[this.button26]));
		w25.Position = 3;
		w25.Expand = false;
		w25.Fill = false;
		// Container child vbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
		this.button27 = new global::Gtk.Button();
		this.button27.CanFocus = true;
		this.button27.Name = "button27";
		this.button27.UseUnderline = true;
		this.button27.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox6.Add(this.button27);
		global::Gtk.ButtonBox.ButtonBoxChild w26 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox6[this.button27]));
		w26.Position = 4;
		w26.Expand = false;
		w26.Fill = false;
		this.hbox8.Add(this.vbuttonbox6);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.vbuttonbox6]));
		w27.Position = 1;
		w27.Expand = false;
		w27.Fill = false;
		this.main_Tabs.Add(this.hbox8);
		global::Gtk.Notebook.NotebookChild w28 = ((global::Gtk.Notebook.NotebookChild)(this.main_Tabs[this.hbox8]));
		w28.Position = 2;
		// Notebook tab
		this.children = new global::Gtk.Label();
		this.children.Name = "children";
		this.children.LabelProp = global::Mono.Unix.Catalog.GetString("Kinder");
		this.main_Tabs.SetTabLabel(this.hbox8, this.children);
		this.children.ShowAll();
		// Container child main_Tabs.Gtk.Notebook+NotebookChild
		this.hbox5 = new global::Gtk.HBox();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.calendar6 = new global::Gtk.Calendar();
		this.calendar6.CanFocus = true;
		this.calendar6.Name = "calendar6";
		this.calendar6.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(43));
		this.calendar6.ShowWeekNumbers = true;
		this.hbox5.Add(this.calendar6);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.calendar6]));
		w29.Position = 0;
		w29.Expand = false;
		w29.Fill = false;
		// Container child hbox5.Gtk.Box+BoxChild
		this.vbuttonbox5 = new global::Gtk.VButtonBox();
		this.vbuttonbox5.Name = "vbuttonbox5";
		this.vbuttonbox5.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(3));
		// Container child vbuttonbox5.Gtk.ButtonBox+ButtonBoxChild
		this.button13 = new global::Gtk.Button();
		this.button13.HeightRequest = 109;
		this.button13.CanFocus = true;
		this.button13.Name = "button13";
		this.button13.UseUnderline = true;
		this.button13.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox5.Add(this.button13);
		global::Gtk.ButtonBox.ButtonBoxChild w30 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox5[this.button13]));
		w30.Expand = false;
		w30.Fill = false;
		// Container child vbuttonbox5.Gtk.ButtonBox+ButtonBoxChild
		this.button14 = new global::Gtk.Button();
		this.button14.CanFocus = true;
		this.button14.Name = "button14";
		this.button14.UseUnderline = true;
		this.button14.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox5.Add(this.button14);
		global::Gtk.ButtonBox.ButtonBoxChild w31 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox5[this.button14]));
		w31.Position = 1;
		w31.Expand = false;
		w31.Fill = false;
		// Container child vbuttonbox5.Gtk.ButtonBox+ButtonBoxChild
		this.button15 = new global::Gtk.Button();
		this.button15.CanFocus = true;
		this.button15.Name = "button15";
		this.button15.UseUnderline = true;
		this.button15.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox5.Add(this.button15);
		global::Gtk.ButtonBox.ButtonBoxChild w32 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox5[this.button15]));
		w32.Position = 2;
		w32.Expand = false;
		w32.Fill = false;
		// Container child vbuttonbox5.Gtk.ButtonBox+ButtonBoxChild
		this.button16 = new global::Gtk.Button();
		this.button16.CanFocus = true;
		this.button16.Name = "button16";
		this.button16.UseUnderline = true;
		this.button16.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox5.Add(this.button16);
		global::Gtk.ButtonBox.ButtonBoxChild w33 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox5[this.button16]));
		w33.Position = 3;
		w33.Expand = false;
		w33.Fill = false;
		// Container child vbuttonbox5.Gtk.ButtonBox+ButtonBoxChild
		this.button17 = new global::Gtk.Button();
		this.button17.CanFocus = true;
		this.button17.Name = "button17";
		this.button17.UseUnderline = true;
		this.button17.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox5.Add(this.button17);
		global::Gtk.ButtonBox.ButtonBoxChild w34 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox5[this.button17]));
		w34.Position = 4;
		w34.Expand = false;
		w34.Fill = false;
		this.hbox5.Add(this.vbuttonbox5);
		global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.vbuttonbox5]));
		w35.Position = 2;
		w35.Expand = false;
		w35.Fill = false;
		this.main_Tabs.Add(this.hbox5);
		global::Gtk.Notebook.NotebookChild w36 = ((global::Gtk.Notebook.NotebookChild)(this.main_Tabs[this.hbox5]));
		w36.Position = 3;
		// Notebook tab
		this.calendar = new global::Gtk.Label();
		this.calendar.Name = "calendar";
		this.calendar.LabelProp = global::Mono.Unix.Catalog.GetString("Kalender");
		this.main_Tabs.SetTabLabel(this.hbox5, this.calendar);
		this.calendar.ShowAll();
		// Container child main_Tabs.Gtk.Notebook+NotebookChild
		this.hbox6 = new global::Gtk.HBox();
		this.hbox6.Name = "hbox6";
		this.hbox6.Spacing = 6;
		// Container child hbox6.Gtk.Box+BoxChild
		this.vbuttonbox3 = new global::Gtk.VButtonBox();
		this.vbuttonbox3.Name = "vbuttonbox3";
		this.vbuttonbox3.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(3));
		// Container child vbuttonbox3.Gtk.ButtonBox+ButtonBoxChild
		this.button8 = new global::Gtk.Button();
		this.button8.HeightRequest = 109;
		this.button8.CanFocus = true;
		this.button8.Name = "button8";
		this.button8.UseUnderline = true;
		this.button8.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox3.Add(this.button8);
		global::Gtk.ButtonBox.ButtonBoxChild w37 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox3[this.button8]));
		w37.Expand = false;
		w37.Fill = false;
		// Container child vbuttonbox3.Gtk.ButtonBox+ButtonBoxChild
		this.button9 = new global::Gtk.Button();
		this.button9.CanFocus = true;
		this.button9.Name = "button9";
		this.button9.UseUnderline = true;
		this.button9.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox3.Add(this.button9);
		global::Gtk.ButtonBox.ButtonBoxChild w38 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox3[this.button9]));
		w38.Position = 1;
		w38.Expand = false;
		w38.Fill = false;
		// Container child vbuttonbox3.Gtk.ButtonBox+ButtonBoxChild
		this.button10 = new global::Gtk.Button();
		this.button10.CanFocus = true;
		this.button10.Name = "button10";
		this.button10.UseUnderline = true;
		this.button10.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox3.Add(this.button10);
		global::Gtk.ButtonBox.ButtonBoxChild w39 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox3[this.button10]));
		w39.Position = 2;
		w39.Expand = false;
		w39.Fill = false;
		// Container child vbuttonbox3.Gtk.ButtonBox+ButtonBoxChild
		this.button11 = new global::Gtk.Button();
		this.button11.CanFocus = true;
		this.button11.Name = "button11";
		this.button11.UseUnderline = true;
		this.button11.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox3.Add(this.button11);
		global::Gtk.ButtonBox.ButtonBoxChild w40 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox3[this.button11]));
		w40.Position = 3;
		w40.Expand = false;
		w40.Fill = false;
		// Container child vbuttonbox3.Gtk.ButtonBox+ButtonBoxChild
		this.button12 = new global::Gtk.Button();
		this.button12.CanFocus = true;
		this.button12.Name = "button12";
		this.button12.UseUnderline = true;
		this.button12.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox3.Add(this.button12);
		global::Gtk.ButtonBox.ButtonBoxChild w41 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox3[this.button12]));
		w41.Position = 4;
		w41.Expand = false;
		w41.Fill = false;
		this.hbox6.Add(this.vbuttonbox3);
		global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.vbuttonbox3]));
		w42.Position = 2;
		w42.Expand = false;
		w42.Fill = false;
		this.main_Tabs.Add(this.hbox6);
		global::Gtk.Notebook.NotebookChild w43 = ((global::Gtk.Notebook.NotebookChild)(this.main_Tabs[this.hbox6]));
		w43.Position = 4;
		// Notebook tab
		this.shoppinglist = new global::Gtk.Label();
		this.shoppinglist.Name = "shoppinglist";
		this.shoppinglist.LabelProp = global::Mono.Unix.Catalog.GetString("Einkaufsliste");
		this.main_Tabs.SetTabLabel(this.hbox6, this.shoppinglist);
		this.shoppinglist.ShowAll();
		// Container child main_Tabs.Gtk.Notebook+NotebookChild
		this.hbox3 = new global::Gtk.HBox();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
		this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
		this.treeview2 = new global::Gtk.TreeView();
		this.treeview2.CanFocus = true;
		this.treeview2.Name = "treeview2";
		this.GtkScrolledWindow1.Add(this.treeview2);
		this.hbox3.Add(this.GtkScrolledWindow1);
		global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.GtkScrolledWindow1]));
		w45.Position = 0;
		// Container child hbox3.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.textview1 = new global::Gtk.TextView();
		this.textview1.CanFocus = true;
		this.textview1.Name = "textview1";
		this.GtkScrolledWindow.Add(this.textview1);
		this.hbox3.Add(this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.GtkScrolledWindow]));
		w47.Position = 1;
		// Container child hbox3.Gtk.Box+BoxChild
		this.vbuttonbox2 = new global::Gtk.VButtonBox();
		this.vbuttonbox2.Name = "vbuttonbox2";
		this.vbuttonbox2.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(3));
		// Container child vbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
		this.button3 = new global::Gtk.Button();
		this.button3.HeightRequest = 109;
		this.button3.CanFocus = true;
		this.button3.Name = "button3";
		this.button3.UseUnderline = true;
		this.button3.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox2.Add(this.button3);
		global::Gtk.ButtonBox.ButtonBoxChild w48 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox2[this.button3]));
		w48.Expand = false;
		w48.Fill = false;
		// Container child vbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
		this.button4 = new global::Gtk.Button();
		this.button4.CanFocus = true;
		this.button4.Name = "button4";
		this.button4.UseUnderline = true;
		this.button4.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox2.Add(this.button4);
		global::Gtk.ButtonBox.ButtonBoxChild w49 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox2[this.button4]));
		w49.Position = 1;
		w49.Expand = false;
		w49.Fill = false;
		// Container child vbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
		this.button5 = new global::Gtk.Button();
		this.button5.CanFocus = true;
		this.button5.Name = "button5";
		this.button5.UseUnderline = true;
		this.button5.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox2.Add(this.button5);
		global::Gtk.ButtonBox.ButtonBoxChild w50 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox2[this.button5]));
		w50.Position = 2;
		w50.Expand = false;
		w50.Fill = false;
		// Container child vbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
		this.button6 = new global::Gtk.Button();
		this.button6.CanFocus = true;
		this.button6.Name = "button6";
		this.button6.UseUnderline = true;
		this.button6.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox2.Add(this.button6);
		global::Gtk.ButtonBox.ButtonBoxChild w51 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox2[this.button6]));
		w51.Position = 3;
		w51.Expand = false;
		w51.Fill = false;
		// Container child vbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
		this.button7 = new global::Gtk.Button();
		this.button7.CanFocus = true;
		this.button7.Name = "button7";
		this.button7.UseUnderline = true;
		this.button7.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox2.Add(this.button7);
		global::Gtk.ButtonBox.ButtonBoxChild w52 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox2[this.button7]));
		w52.Position = 4;
		w52.Expand = false;
		w52.Fill = false;
		this.hbox3.Add(this.vbuttonbox2);
		global::Gtk.Box.BoxChild w53 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.vbuttonbox2]));
		w53.Position = 2;
		w53.Expand = false;
		w53.Fill = false;
		this.main_Tabs.Add(this.hbox3);
		global::Gtk.Notebook.NotebookChild w54 = ((global::Gtk.Notebook.NotebookChild)(this.main_Tabs[this.hbox3]));
		w54.Position = 5;
		// Notebook tab
		this.recipes = new global::Gtk.Label();
		this.recipes.Name = "recipes";
		this.recipes.LabelProp = global::Mono.Unix.Catalog.GetString("Rezepte");
		this.main_Tabs.SetTabLabel(this.hbox3, this.recipes);
		this.recipes.ShowAll();
		// Container child main_Tabs.Gtk.Notebook+NotebookChild
		this.hbox10 = new global::Gtk.HBox();
		this.hbox10.Name = "hbox10";
		this.hbox10.Spacing = 6;
		// Container child hbox10.Gtk.Box+BoxChild
		this.vbuttonbox8 = new global::Gtk.VButtonBox();
		this.vbuttonbox8.Name = "vbuttonbox8";
		this.vbuttonbox8.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(3));
		// Container child vbuttonbox8.Gtk.ButtonBox+ButtonBoxChild
		this.button33 = new global::Gtk.Button();
		this.button33.HeightRequest = 109;
		this.button33.CanFocus = true;
		this.button33.Name = "button33";
		this.button33.UseUnderline = true;
		this.button33.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox8.Add(this.button33);
		global::Gtk.ButtonBox.ButtonBoxChild w55 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox8[this.button33]));
		w55.Expand = false;
		w55.Fill = false;
		// Container child vbuttonbox8.Gtk.ButtonBox+ButtonBoxChild
		this.button34 = new global::Gtk.Button();
		this.button34.CanFocus = true;
		this.button34.Name = "button34";
		this.button34.UseUnderline = true;
		this.button34.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox8.Add(this.button34);
		global::Gtk.ButtonBox.ButtonBoxChild w56 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox8[this.button34]));
		w56.Position = 1;
		w56.Expand = false;
		w56.Fill = false;
		// Container child vbuttonbox8.Gtk.ButtonBox+ButtonBoxChild
		this.button35 = new global::Gtk.Button();
		this.button35.CanFocus = true;
		this.button35.Name = "button35";
		this.button35.UseUnderline = true;
		this.button35.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox8.Add(this.button35);
		global::Gtk.ButtonBox.ButtonBoxChild w57 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox8[this.button35]));
		w57.Position = 2;
		w57.Expand = false;
		w57.Fill = false;
		// Container child vbuttonbox8.Gtk.ButtonBox+ButtonBoxChild
		this.button36 = new global::Gtk.Button();
		this.button36.CanFocus = true;
		this.button36.Name = "button36";
		this.button36.UseUnderline = true;
		this.button36.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox8.Add(this.button36);
		global::Gtk.ButtonBox.ButtonBoxChild w58 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox8[this.button36]));
		w58.Position = 3;
		w58.Expand = false;
		w58.Fill = false;
		// Container child vbuttonbox8.Gtk.ButtonBox+ButtonBoxChild
		this.button37 = new global::Gtk.Button();
		this.button37.CanFocus = true;
		this.button37.Name = "button37";
		this.button37.UseUnderline = true;
		this.button37.Label = global::Mono.Unix.Catalog.GetString("Test");
		this.vbuttonbox8.Add(this.button37);
		global::Gtk.ButtonBox.ButtonBoxChild w59 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox8[this.button37]));
		w59.Position = 4;
		w59.Expand = false;
		w59.Fill = false;
		this.hbox10.Add(this.vbuttonbox8);
		global::Gtk.Box.BoxChild w60 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.vbuttonbox8]));
		w60.Position = 2;
		w60.Expand = false;
		w60.Fill = false;
		this.main_Tabs.Add(this.hbox10);
		global::Gtk.Notebook.NotebookChild w61 = ((global::Gtk.Notebook.NotebookChild)(this.main_Tabs[this.hbox10]));
		w61.Position = 6;
		// Notebook tab
		this.meal = new global::Gtk.Label();
		this.meal.Name = "meal";
		this.meal.LabelProp = global::Mono.Unix.Catalog.GetString("Essensplan");
		this.main_Tabs.SetTabLabel(this.hbox10, this.meal);
		this.meal.ShowAll();
		// Container child main_Tabs.Gtk.Notebook+NotebookChild
		this.hbox9 = new global::Gtk.HBox();
		this.hbox9.Name = "hbox9";
		this.hbox9.Spacing = 6;
		this.main_Tabs.Add(this.hbox9);
		global::Gtk.Notebook.NotebookChild w62 = ((global::Gtk.Notebook.NotebookChild)(this.main_Tabs[this.hbox9]));
		w62.Position = 7;
		// Notebook tab
		this.household = new global::Gtk.Label();
		this.household.Name = "household";
		this.household.LabelProp = global::Mono.Unix.Catalog.GetString("Haushaltsbuch");
		this.main_Tabs.SetTabLabel(this.hbox9, this.household);
		this.household.ShowAll();
		this.main_Layout_horizontal.Add(this.main_Tabs);
		global::Gtk.Box.BoxChild w63 = ((global::Gtk.Box.BoxChild)(this.main_Layout_horizontal[this.main_Tabs]));
		w63.Position = 1;
		// Container child main_Layout_horizontal.Gtk.Box+BoxChild
		this.statusbar = new global::Gtk.Statusbar();
		this.statusbar.Name = "statusbar";
		this.statusbar.Spacing = 6;
		this.main_Layout_horizontal.Add(this.statusbar);
		global::Gtk.Box.BoxChild w64 = ((global::Gtk.Box.BoxChild)(this.main_Layout_horizontal[this.statusbar]));
		w64.Position = 2;
		w64.Expand = false;
		w64.Fill = false;
		this.Add(this.main_Layout_horizontal);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 1157;
		this.DefaultHeight = 600;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
	}
}
