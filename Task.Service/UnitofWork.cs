using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Data;

namespace Task.Service
{
    public class UnitofWork:IDisposable
    {
        private readonly EFBlogContext context;
        public UnitofWork()
        {
            context = new EFBlogContext();
        }


        #region Variables
        private UserService _userService;
        private NoteService _noteService;
        private CurrencyRecordService _recordService;
        #endregion

        #region Services
        public UserService Users
        {
            get
            {
                if (_userService == null)
                    _userService = new UserService(context);

                return _userService;
            }
        }

        public NoteService Notes
        {
            get
            {
                if (_noteService == null)
                    _noteService = new NoteService(context);

                    return _noteService;
            }
        }

        public CurrencyRecordService CurrencyRecords
        {
            get
            {
                if (_recordService == null)
                    _recordService = new CurrencyRecordService(context);

                return _recordService;
            }
        }



        #endregion

        #region IDisposable Members
        // Burada IUnitOfWork arayüzüne implemente ettiğimiz IDisposable arayüzünün Dispose Patternini implemente ediyoruz.
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }

            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }


}