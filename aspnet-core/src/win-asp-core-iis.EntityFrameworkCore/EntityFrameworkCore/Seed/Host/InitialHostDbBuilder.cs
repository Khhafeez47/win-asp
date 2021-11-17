namespace win-asp-core-iis.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly win-asp-core-iisDbContext _context;

        public InitialHostDbBuilder(win-asp-core-iisDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
