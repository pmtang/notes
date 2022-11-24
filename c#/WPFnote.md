### 1. Setting Datacontext
[stackoverflow link](https://stackoverflow.com/questions/69203973/whats-the-difference-in-this-example-between-using-datacontext-in-xaml-code-b)

### 2. Binding
**important:** You can only bind to **properties**, not fields.

(In MVVM) Following is a demo of Binding combining C# and xaml:  

    // ViewModel
    class MainViewModel
    {
        public string TestBind { get; set; } = "hi";                // Binding Source

    // View: XAML
    <Window
        x:Class="Banqi.MainWindow"
        ...>

        <Window.DataContext>
            <viewmodel:MainViewModel x:Name="<b>testModel</b>" />   // Name to indicate
        </Window.DataContext>

        <Grid x:Name="MyGrid">                                      // Name to indicate
            <Grid.ColumnDefinitions>
                ...
            </Grid.ColumnDefinitions>
            <Grid.RowDefinitions>
                ...
            </Grid.RowDefinitions>
    ...

    // View: C#
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // add control with C#
            TextBlock myblock = new TextBlock();                    // Binding Target
            MyGrid.Children.Add(myblock);
            Grid.SetRow(myblock, 2);
            Grid.SetColumn(myblock, 2);

            // add Binding to Property "TestBind" in ViewModel      // important parts
            Binding myBinding= new Binding("TestBind");
            myBinding.Source = testModel;
            myblock.SetBinding(TextBlock.TextProperty, myBinding);
        }
    }

[MSDN link](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/data/?view=netdesktop-6.0)  
[stackoverflow link](https://stackoverflow.com/questions/7525185/how-to-set-a-binding-in-code)

### 3. Add button to grid
    Button button = new Button();
    button.Name = "Btn" + row + col;
    Grid.SetRow(button, row);
    Grid.SetColumn(button, col);
    grid.Children.Add(button);

### 4. Handle event
[stackoverflow link](https://stackoverflow.com/questions/37214401/why-mousedown-event-handler-is-not-getting-hit)

    button.PreviewMouseDown += OnBtnClick;
    button.MouseDown += OnBtnClick;
    // the PreviewXXX version is 'tunnel' event and is raised on higher level
    // vs. the XXX version is 'bubble' event and start bubble up and is easily get caughy and handled