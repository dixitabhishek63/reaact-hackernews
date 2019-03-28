namespace Shertech001.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly Shertech001DbContext _context;

        public InitialHostDbBuilder(Shertech001DbContext context)
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
