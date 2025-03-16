using System;
using Business;
using DataAccess;
using Entities;

class Program
{
    static void Main()
    {
        var languageRepo = new ProgrammingLanguageRepository();
        var languageManager = new ProgrammingLanguageManager(languageRepo);

        while (true)
        {
            Console.WriteLine("\n--- Programlama Dili Yönetimi ---");
            Console.WriteLine("1. Yeni Programlama Dili Ekle");
            Console.WriteLine("2. Tüm Dilleri Listele");
            Console.WriteLine("3. Çıkış");
            Console.Write("Seçiminiz: ");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.Write("Programlama dili adı girin: ");
                string name = Console.ReadLine();
                ProgrammingLanguage language = new ProgrammingLanguage { Id = languageManager.GetAllProgrammingLanguages().Count + 1, Name = name };
                languageManager.AddProgrammingLanguage(language);
                Console.WriteLine("Programlama dili eklendi.");
            }
            else if (secim == "2")
            {
                Console.WriteLine("\nKayıtlı Programlama Dilleri:");
                foreach (var lang in languageManager.GetAllProgrammingLanguages())
                {
                    Console.WriteLine($"ID: {lang.Id}, Name: {lang.Name}");
                }
            }
            else if (secim == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Geçersiz seçim! Tekrar deneyin.");
            }
        }
    }
}
