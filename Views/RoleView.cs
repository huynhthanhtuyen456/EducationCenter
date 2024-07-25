using DataLayer;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Views
{
    public partial class RoleView : Form
    {
        private EducationCenterContext? EducationCenterContext;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.EducationCenterContext = new EducationCenterContext();

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            this.EducationCenterContext.Database.EnsureCreated();
            this.EducationCenterContext.Roles.Load();
            this.DataGridViewTeacher.DataSource = EducationCenterContext.Roles.Local.ToBindingList();
        }
        public RoleView()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.EducationCenterContext?.Dispose();
            this.EducationCenterContext = null;
        }
    }
}
