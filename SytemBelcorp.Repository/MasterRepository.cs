namespace SytemBelcorp.Repository
{
    public abstract class MasterRepository
    {
        private SytemBelcorpContex _context;

        public MasterRepository()
        {
            if (_context == null)
                _context = new SytemBelcorpContex();
        }

        protected SytemBelcorpContex Context
        {
            get { return _context; }
        }
    }
}
