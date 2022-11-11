namespace Scanizr.Sample.Forms
{
    public partial class App : Shiny.FrameworkApplication
    {
        protected override void OnInitialized()
        {
            XF.Material.Forms.Material.Init(this);
            InitializeComponent();
            base.Initialize();
        }
    }
}
