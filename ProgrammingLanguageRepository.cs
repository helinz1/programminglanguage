using Entities;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class ProgrammingLanguageRepository : IRepository<ProgrammingLanguage>
    {
        private List<ProgrammingLanguage> languages = new List<ProgrammingLanguage>();

        public void Add(ProgrammingLanguage entity) => languages.Add(entity);
        public List<ProgrammingLanguage> GetAll() => languages;
        public void Delete(int id) => languages.RemoveAll(l => l.Id == id);
        public void Update(ProgrammingLanguage entity)
        {
            var lang = GetById(entity.Id);
            if (lang != null) lang.Name = entity.Name;
        }
        public ProgrammingLanguage GetById(int id) => languages.FirstOrDefault(l => l.Id == id);
    }
}
