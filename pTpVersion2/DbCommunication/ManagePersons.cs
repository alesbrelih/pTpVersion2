using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pTpVersion2.Data.DatabaseModels;
using pTpVersion2.Data.DatabaseModels.DbContext;
using pTpVersion2.Data.DatabaseModels.ViewModels;

namespace pTpVersion2.DbCommunication
{
    public class ManagePersons
    {
        //returns persons
        public static ObservableCollection<PersonView> ReturnPersons()
        {
            var list = new ObservableCollection<PersonView>();
            using (var db = new PtpContext())
            {
                foreach (var person in db.Persons)
                {
                    list.Add(new PersonView()
                    {
                        PersonId = person.PersonId,
                        Name = person.Name,
                        Surname = person.Surname,
                        Email = person.Email,
                        Telephone = person.Telephone,
                        Foreigner = person.Foreigner
                    });
                }


            }
            return list;
        }

        internal static void AddPerson(PersonView person)
        {
            var personModel = new Person()
            {
                Name = person.Name,
                Surname = person.Surname,
                Email = person.Email,
                Telephone = person.Telephone,
                Foreigner = person.Foreigner
            };

            using (var db = new PtpContext())
            {
                db.Persons.Add(personModel);
                db.SaveChanges();
            }
        }

        internal static void EditPerson(PersonView person)
        {
            using (var db = new PtpContext())
            {
                var personDB = db.Persons.Find(person.PersonId);
                personDB.Name = person.Name;
                personDB.Surname = person.Surname;
                personDB.Email = person.Email;
                personDB.Telephone = person.Telephone;
                personDB.Foreigner = person.Foreigner;

                db.Entry(personDB).State=EntityState.Modified;
                db.SaveChanges();
            }}



        //deletes person from db
        internal static void DeletePerson(PersonView selectedPerson)
        {
            using (var db = new PtpContext())
            {
                var personDb = db.Persons.Find(selectedPerson.PersonId);
                db.Persons.Remove(personDb);
                db.SaveChanges();
            }
        }

        //returns selected person
        internal static PersonView FindPerson(int? personId)
        {
            using (var db = new PtpContext())
            {
                var person = db.Persons.Find(personId);
                return new PersonView()
                {
                    PersonId = person.PersonId,
                    Name = person.Name,
                    Surname = person.Surname,
                    Email = person.Email,
                    Telephone = person.Telephone,
                    Foreigner = person.Foreigner
                };
            }

            
            
        }
    }
}
