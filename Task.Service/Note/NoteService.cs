using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using Task.Data;
using Task.Data.Model;
using Task.Data.Repositories;

namespace Task.Service
{
    public class NoteService
    {
 
        private EFRepository<Note> _noteTextRepository;
       
        public NoteService(EFBlogContext EFBlogContext)
        {        
            _noteTextRepository = new EFRepository<Note>(EFBlogContext);
          
        }
        public List<Note> GetDeletedNotes(bool status)
        {
           
              List<Note> sorgu = _noteTextRepository.GetAll().Where(n => n.IsDeleted == true).ToList();
              return sorgu;
          
        }

        public List<Note> Notes()
        {      
                List<Note> sorgu = _noteTextRepository.GetAll().ToList();
                return sorgu;
                     
        }



    }

}
