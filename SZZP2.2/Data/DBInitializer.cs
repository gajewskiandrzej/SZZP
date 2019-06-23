using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SZZP2._2.Models;

namespace SZZP2._2.Data
{
    public class DBInitializer
    {
        public static void Initialize(SZZPContext context)
        {
            context.Database.EnsureCreated();


            //Look for any offices.
            if(context.Offices.Any())
            {
                return; //DB has been seeded
            }

            var offices = new Office[]
            {
                new Office{NameOffice="Biuro Administracji i Eksploatacji Nieruchomości",SymbolOffice="KNE"},
                new Office{NameOffice="Biuro Analiz i Efektywności Procesów",SymbolOffice="KNA"},
                new Office{NameOffice="Biuro Audytu i Kontroli",SymbolOffice="KOA"},
                new Office{NameOffice="Biuro Bezpieczeństwa",SymbolOffice="KOB"},
                new Office{NameOffice="Wydział Bezpieczeństwa i Higieny Pracy",SymbolOffice="KBH"},
                new Office{NameOffice="Biuro Finansów i Rachunkowości",SymbolOffice="KFR"},
                new Office{NameOffice="Biuro Funduszy",SymbolOffice="KIF"},
                new Office{NameOffice="Biuro Geodezji i Ewidencji Nieruchomości",SymbolOffice="KSE"},
                new Office{NameOffice="Biuro Infrastruktury Pasażerskiej i Obsługi Klienta",SymbolOffice="KSI"},
                new Office{NameOffice="Biuro Inwestycji",SymbolOffice="KII"},
                new Office{NameOffice="Biuro Komunikacji i Promocji",SymbolOffice="KOM"},
                new Office{NameOffice="Biuro Kontrolingu i Analiz Grupy PKP",SymbolOffice="KFK"},
                new Office{NameOffice="Kolejowa Medycyna Pracy",SymbolOffice="KMP"},
                new Office{NameOffice="Zespół ds. Komercajlizacji Powierzchni Reklamowych",SymbolOffice="KOR"},
                new Office{NameOffice="Biuro Logistyki",SymbolOffice="KSL"},
                new Office{NameOffice="Biuro Obrotu Nieruchomościami",SymbolOffice="KNO"},
                new Office{NameOffice="Biuro Projektów Deweloperskich i Mieszkaniowych",SymbolOffice="KND"},
                new Office{NameOffice="Biuro Prawne i Nadzoru Właścicielskiego",SymbolOffice="KOP"},
                new Office{NameOffice="Pion Ochrony Informacji Niejawnych i Spraw Obronnych",SymbolOffice="KPO"},
                new Office{NameOffice="Biuro Spraw Pracowniczych",SymbolOffice="KOK"},
                new Office{NameOffice="Biuro Strategii i Rozwoju",SymbolOffice="KSR"},
                new Office{NameOffice="Biuro Teleinformatyki",SymbolOffice="KIT"},
                new Office{NameOffice="Biuro Windykacji",SymbolOffice="KFW"},
                new Office{NameOffice="Biuro Zakupów",SymbolOffice="KFZ"},
                new Office{NameOffice="Biuro Zarządu",SymbolOffice="KOZ"},
            };
            foreach(Office o in offices)
            {
                context.Offices.Add(o);
            }
            context.SaveChanges();

            var departments = new Department[]
            {
                new Department{IDOffice=1,NameDepartment="Wydział Eksploatacji", SymbolDeprtament="KNE01"},
                new Department{IDOffice=11,NameDepartment="Wydział Marketingu i Promocji", SymbolDeprtament="KOM02"},
                new Department{IDOffice=20,NameDepartment="Wydział Obsługi Pracowników", SymbolDeprtament="KOK03"},
                new Department{IDOffice=22,NameDepartment="Zespół ds. Systemów Dziedzinowych", SymbolDeprtament="KIT02"},
                new Department{IDOffice=22,NameDepartment="Zespół Administratorów Systemów Teleinformatycznych", SymbolDeprtament="KIT02"}
            };
            foreach (Department d in departments)
            {
                context.Departments.Add(d);
            }
            context.SaveChanges();

            var positions = new Position[]
            {
                new Position{NamePosition="specjalista"},
                new Position{NamePosition="starszy specjalista"},
                new Position{NamePosition="główny specjalista"},
                new Position{NamePosition="ekspert"},
                new Position{NamePosition="dyrektor projektu"},
                new Position{NamePosition="zastępca dyrektora biura"},
                new Position{NamePosition="dyrektor biura"}
            };
            foreach (Position p in positions)
            {
                context.Positions.Add(p);
            }
            context.SaveChanges();

            var statuses = new Status[]
            {
                new Status{NameStatus="HR Workflow"},
                new Status{NameStatus="IT Workflow"},
                new Status{NameStatus="Zapisz do AD"}
            };
            foreach (Status s in statuses)
            {
                context.Statuses.Add(s);
            }
            context.SaveChanges();

            var employments = new Employment[]
            {
                new Employment{Name="Janusz",Surname="Kowalski",NrSap="80000123",DateEmployment=DateTime.Parse("2015-01-31") ,EndContract=DateTime.Parse("2020-01-31"),IDOffice=1,OfficeSymbol="KNE",IDDepartment=1,IDStatus= 1, IDPosition = 1},
                new Employment{Name="Stefan",Surname="Nowak",NrSap="80000122",DateEmployment=DateTime.Parse("2016-07-15") ,EndContract=DateTime.Parse("2021-06-30"),IDOffice=1,OfficeSymbol="KNE",IDDepartment=1,IDStatus=1, IDPosition = 1}
            };
            foreach (Employment e in employments)
            {
                context.SaveChanges();
            }

        }
    }
}




//var appusers = new APPUser[]
//{
//    new APPUser{Login="andrzej.gajewski",Password="123",IDRole=1},
//    new APPUser{Login="mariusz.kulesza",Password="123",IDRole=2},
//    new APPUser{Login="julita.kuzniak",Password="123",IDRole=3}
//};
//foreach (APPUser a in appusers)
//{
//    context.SaveChanges();
//}