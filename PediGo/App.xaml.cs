using PediGo.Data;

namespace PediGo
{
    public partial class App : Application
    {
        private readonly SqliteServer _sqliteDatabase;
        public App(SqliteServer sqliteServer)
        {
            InitializeComponent();
            _sqliteDatabase = sqliteServer;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }

        protected override async void OnStart()
        {
            base.OnStart();

            // Initialize Sqlite Database on start
            await _sqliteDatabase.InitializeAndCreate();
        }
    }
}