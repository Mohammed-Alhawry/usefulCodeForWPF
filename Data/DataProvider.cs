

using Bogus;
using ExperimentalThingsUsingWPF.Models;
using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace ExperimentalThingsUsingWPF.Data;

public static class DataProvider
{
    public static ObservableCollection<MaterialModel> GetMaterials()
    {
        return new ObservableCollection<MaterialModel>
        {
            new MaterialModel
            {
                Id = 1,
                ShortName = "ALK",
                FullName = "laskdflsdkf"
            }
            ,new MaterialModel
            {
                Id = 2,
                ShortName = "SSsdfsdfK",
                FullName = "laskdflsdsdfasdfasdfkf"

            }
            ,new MaterialModel
            {
                Id = 3,
                ShortName = "AL",
                FullName = "lasskdflsdkf"

            },
            new MaterialModel
            {
                Id = 4,
                ShortName = "ALKsd",
                FullName = "laskdfsdflsdkf"
            },
            new MaterialModel
            {
                Id = 1,
                ShortName = "ALK",
                FullName = "laskdflsdkf"
            }
            ,new MaterialModel
            {
                Id = 2,
                ShortName = "SSsdfsdfK",
                FullName = "laskdflsdsdfasdfasdfkf"
            }
            ,new MaterialModel
            {
                Id = 3,
                ShortName = "AL",
                FullName = "lasskdflsdkf"
            },
            new MaterialModel
            {
                Id = 4,
                ShortName = "ALKsd",
                FullName = "laskdfsdflsdkf"
            }
        };
    }
    public static ObservableCollection<ClinicModel> GetClinics()
    {
        return new ObservableCollection<ClinicModel>
        {
            new ClinicModel{Id = 1, Name = "alsharabi", Address = "alomairi, street 1"
            , Contacts = (ObservableCollection<ClinicContactModel>)GetClinicsContacts().Where(e => e.ClinicId == 1)},
            new ClinicModel{Id = 2, Name = "aloamiri", Address = "alhawry, street 3" ,
            Contacts = (ObservableCollection<ClinicContactModel>)GetClinicsContacts().Where(e => e.ClinicId == 2)},
            new ClinicModel{Id = 3, Name = "alhawry", Address = "Sana'a, street 12"
            ,Contacts = (ObservableCollection<ClinicContactModel>)GetClinicsContacts().Where(e => e.ClinicId == 3)},
            new ClinicModel{Id = 4, Name = "jamali", Address = "Bab alyemen, street 11"
            ,Contacts = (ObservableCollection<ClinicContactModel>)GetClinicsContacts().Where(e => e.ClinicId == 4)},
            // still there should be requests are missing
        };
    }
    public static ObservableCollection<WorkTypeModel> GetWorksTypes()
    {
        return new ObservableCollection<WorkTypeModel>
        {
            new WorkTypeModel{Id = 1, Name = "abssdfasdfsdfasdf", Info = "alskd fajls kdjfls kdjflk sjdflk jsdkfj", Price = 1212},
            new WorkTypeModel{Id = 2, Name = "alsdkf la", Info = "sdaf alsdkfj ;lasdkfj lsdfj ", Price = 10012.234M},
            new WorkTypeModel{Id = 3, Name = "sldfk lsdkfj s", Info = "alskdf sdf ajlskdj flskdjfl ksjdflkjsdkfj", Price = 12432.32M},
            new WorkTypeModel{Id = 4, Name = "lsa ;alskdf sldf", Info = "alskd fajlsk djflsk djflks jdflkjsdkfj", Price = 10000.123M},
            new WorkTypeModel{Id = 5, Name = "sldfj lskdaf a", Info = "alsk dfajls kdjflskdjd flksjd flkjsdkfj", Price = 11212.50M},
            new WorkTypeModel{Id = 6, Name = "xms slkdjf s", Info = "alskdf ajlsk djflskdj flksjdflkjsdkfj", Price = 24049},
        };
    }
    public static ObservableCollection<RequestModel> GetRequests()
    {
        return new ObservableCollection<RequestModel>
        {
            new RequestModel{Id = 1, RequestData = DateTime.Now, DeliveryDate = DateTime.Today.AddDays(20), WorkTypeId = 1, ClinicId = 1},
            new RequestModel{Id = 2, RequestData = DateTime.Now, DeliveryDate = DateTime.Today.AddDays(21), WorkTypeId = 2, ClinicId = 2},
            new RequestModel{Id = 3, RequestData = DateTime.Now, DeliveryDate = DateTime.Today.AddDays(22), WorkTypeId = 3, ClinicId = 3},
            new RequestModel{Id = 4, RequestData = DateTime.Now, DeliveryDate = DateTime.Today.AddDays(23), WorkTypeId = 4, ClinicId = 4},
            new RequestModel{Id = 5, RequestData = DateTime.Now, DeliveryDate = DateTime.Today.AddDays(24), WorkTypeId = 5, ClinicId = 2},
            new RequestModel{Id = 6, RequestData = DateTime.Now, DeliveryDate = DateTime.Today.AddDays(30), WorkTypeId = 6, ClinicId = 1},
        };
    }
    public static ObservableCollection<BillModel> GetBills()
    {
        return new ObservableCollection<BillModel>
        {
            new BillModel{Id = 1, BillDate = DateTime.Today, RequestId = 1, TotalPrice = 10012, PaymentState = PaymentState.Type1
            , Payments = (ObservableCollection<PaymentModel>)GetPayments().Where(e => e.BillId == 1)},
            new BillModel{Id = 2, BillDate = DateTime.Today.AddDays(1), RequestId = 2, TotalPrice = 12323, PaymentState = PaymentState.Type2
            , Payments = (ObservableCollection<PaymentModel>)GetPayments().Where(e => e.BillId == 2)},
            new BillModel{Id = 3, BillDate = DateTime.Today.AddDays(2), RequestId = 3, TotalPrice = 10012.23423M, PaymentState = PaymentState.Type3
            , Payments = (ObservableCollection<PaymentModel>)GetPayments().Where(e => e.BillId == 3)},
            new BillModel{Id = 4, BillDate = DateTime.Today.AddDays(3), RequestId = 4, TotalPrice = 100, PaymentState = PaymentState.Type2
            , Payments = (ObservableCollection<PaymentModel>)GetPayments().Where(e => e.BillId == 4)},
            new BillModel{Id = 5, BillDate = DateTime.Today.AddDays(4), RequestId = 5, TotalPrice = 1501, PaymentState = PaymentState.Type1
            , Payments = (ObservableCollection<PaymentModel>)GetPayments().Where(e => e.BillId == 5)},
            new BillModel{Id = 6, BillDate = DateTime.Today.AddDays(5), RequestId = 6, TotalPrice = 100.123M, PaymentState = PaymentState.Type3
            , Payments = (ObservableCollection<PaymentModel>)GetPayments().Where(e => e.BillId == 6)},
        };
    }
    public static ObservableCollection<PaymentModel> GetPayments()
    {
        return new ObservableCollection<PaymentModel>
        {
            new PaymentModel{Id = 1, PaymentDate = DateTime.Today, PaidMoney = 122, PaymentMethod = PaymentMethod.Cash,TransformReference = "1298129812", BillId = 1},
            new PaymentModel{Id = 2, PaymentDate = DateTime.Today.AddDays(3), PaidMoney = 100.12M, PaymentMethod = PaymentMethod.Electronic,TransformReference = "12345436", BillId = 1},
            new PaymentModel{Id = 3, PaymentDate = DateTime.Today.AddDays(1), PaidMoney = 346, PaymentMethod = PaymentMethod.Cash,TransformReference = "12985645712", BillId = 2},
            new PaymentModel{Id = 4, PaymentDate = DateTime.Today.AddDays(30), PaidMoney = 678, PaymentMethod = PaymentMethod.Cash,TransformReference = "6757542", BillId = 3},
            new PaymentModel{Id = 5, PaymentDate = DateTime.Today.AddDays(24), PaidMoney = 258, PaymentMethod = PaymentMethod.Electronic,TransformReference = "8908909812", BillId = 4},
            new PaymentModel{Id = 6, PaymentDate = DateTime.Today.AddDays(14), PaidMoney = 789, PaymentMethod = PaymentMethod.Cash,TransformReference = "089812", BillId = 5},
            new PaymentModel{Id = 7, PaymentDate = DateTime.Today.AddDays(20), PaidMoney = 124234.2M, PaymentMethod = PaymentMethod.Electronic,TransformReference = "0098129812", BillId = 3},
        };
    }
    public static ObservableCollection<EmployeeContactModel> GetEmployeesContacts()
    {
        return new ObservableCollection<EmployeeContactModel>
        {
            new EmployeeContactModel{EmployeeId = 1, ContactInfo = "alhawrycoder@gmail.com", ContactType = ContactType.PrimaryEmail},
            new EmployeeContactModel{EmployeeId = 2, ContactInfo = "OsamaAlansi@gmail.com", ContactType = ContactType.AlternativeEmail},
            new EmployeeContactModel{EmployeeId = 3, ContactInfo = "781288212", ContactType = ContactType.PrimaryPhoneNumber},
            new EmployeeContactModel{EmployeeId = 4, ContactInfo = "918393282", ContactType = ContactType.AlternativePhoneNumber},
            new EmployeeContactModel{EmployeeId = 1, ContactInfo = "919121212", ContactType = ContactType.PrimaryPhoneNumber},
            new EmployeeContactModel{EmployeeId = 1, ContactInfo = "Hasan@gmail.com", ContactType = ContactType.PrimaryEmail},
            new EmployeeContactModel{EmployeeId = 3, ContactInfo = "alhawrycoder@gmail.com", ContactType = ContactType.AlternativePhoneNumber},
            new EmployeeContactModel{EmployeeId = 2, ContactInfo = "Rashad@gmail.com", ContactType = ContactType.AlternativeEmail},
        };
    }
    public static ObservableCollection<EmployeeModel> GetEmployees()
    {
        return new ObservableCollection<EmployeeModel>
        {
            new EmployeeModel{Id = 1, Address = "alhawry", FullName = "Eman Yahya Mohammed", Gender = GenderType.Female
            ,Qualification = "alsdkfalsdkfajsldfkj;lsdkfjlsdkfjlksdjflksdjflsdjf;lskdfjalsdkfj", EmployeeType = EmployeeType.Technecian,
                Contacts = (ObservableCollection<EmployeeContactModel>)GetEmployeesContacts().Where(e => e.EmployeeId == 1),
            Attendances = (ObservableCollection<AttendanceModel>)GetAttendances().Where(e => e.EmployeeId == 1)},
            new EmployeeModel{Id = 2, Address = "Aloamiri", FullName = "Rashad Alkholani", Gender = GenderType.Male
            ,Qualification = "alsdkfalsdkfajsldfkj;lsdkfjlsdkfjlksdjflksdjflsdjf;lskdfjalsdkfj", EmployeeType = EmployeeType.Secretary,
                Contacts = (ObservableCollection<EmployeeContactModel>)GetEmployeesContacts().Where(e => e.EmployeeId == 2)
            ,Attendances = (ObservableCollection<AttendanceModel>)GetAttendances().Where(e => e.EmployeeId == 2)},
            new EmployeeModel{Id = 3, Address = "Sana'a", FullName = "Ghalab Mohammed", Gender = GenderType.Male
            ,Qualification = "alsdkfalsdkfajsldfkj;lsdkfjlsdkfjlksdjflksdjflsdjf;lskdfjalsdkfj", EmployeeType = EmployeeType.Manager,
                Contacts = (ObservableCollection<EmployeeContactModel>)GetEmployeesContacts().Where(e => e.EmployeeId == 3)
            ,Attendances = (ObservableCollection<AttendanceModel>)GetAttendances().Where(e => e.EmployeeId == 3)},
            new EmployeeModel{Id = 4, Address = "Haja", FullName = "Osama Ibraheem Mohammed Alansi", Gender = GenderType.Male
            ,Qualification = "alsdkfalsdkfajsldfkj;lsdkfjlsdkfjlksdjflksdjflsdjf;lskdfjalsdkfj", EmployeeType = EmployeeType.Technecian,
                Contacts = (ObservableCollection<EmployeeContactModel>)GetEmployeesContacts().Where(e => e.EmployeeId == 4)
            ,Attendances = (ObservableCollection<AttendanceModel>)GetAttendances().Where(e => e.EmployeeId == 4)},

            // attendances still missing
        };
    }
    public static ObservableCollection<DoctorModel> GetDoctors()
    {
        return new ObservableCollection<DoctorModel>
        {
            new DoctorModel{Id = 1, Address = "alhawry", FullName = "Sarah Yaseen Alyashmori", Gender = GenderType.Female, ClinicId = 1
            ,Contacts = (ObservableCollection<DoctorContactModel>)GetDoctorsContacts().Where(e => e.DoctorId == 1)},
            new DoctorModel{Id = 2, Address = "alomairi", FullName = "Mohammed Ali Hosain Altoaiti", Gender = GenderType.Male, ClinicId = 2
            ,Contacts = (ObservableCollection<DoctorContactModel>)GetDoctorsContacts().Where(e => e.DoctorId == 2)},
            new DoctorModel{Id = 3, Address = "Yareem", FullName = "Abd alkareem yaseen almonisi", Gender = GenderType.Male, ClinicId = 3
            ,Contacts = (ObservableCollection<DoctorContactModel>)GetDoctorsContacts().Where(e => e.DoctorId == 3)},
            new DoctorModel{Id = 4, Address = "Sana'a", FullName = "Abd allah Hosain ahmed ghalab", Gender = GenderType.Male, ClinicId = 4
            ,Contacts = (ObservableCollection<DoctorContactModel>)GetDoctorsContacts().Where(e => e.DoctorId == 4)},
        };
    }
    public static ObservableCollection<DoctorContactModel> GetDoctorsContacts()
    {
        return new ObservableCollection<DoctorContactModel>
        {
            new DoctorContactModel{DoctorId = 1, ContactInfo = "923872938723", ContactType = ContactType.PrimaryPhoneNumber},
            new DoctorContactModel{DoctorId = 1, ContactInfo = "928349834", ContactType = ContactType.AlternativePhoneNumber},
            new DoctorContactModel{DoctorId = 2, ContactInfo = "alhawry@gmail.com", ContactType = ContactType.PrimaryEmail},
            new DoctorContactModel{DoctorId = 3, ContactInfo = "almonisi@gmail.com", ContactType = ContactType.PrimaryEmail},
            new DoctorContactModel{DoctorId = 4, ContactInfo = "9832923823", ContactType = ContactType.AlternativePhoneNumber},
            new DoctorContactModel{DoctorId = 3, ContactInfo = "77719813983984", ContactType = ContactType.PrimaryPhoneNumber},
            new DoctorContactModel{DoctorId = 4, ContactInfo = "ahmedsadeg@gmail.com", ContactType = ContactType.AlternativeEmail},
        };
    }
    public static ObservableCollection<AttendanceModel> GetAttendances()
    {
        return new ObservableCollection<AttendanceModel>
        {
            new AttendanceModel{EmployeeId = 1, AttendanceTime = DateTime.Now, DepartureTime = DateTime.Now.AddDays(1)},
            new AttendanceModel{EmployeeId = 2, AttendanceTime = DateTime.Now.AddMinutes(12), DepartureTime = DateTime.Now.AddDays(2)},
            new AttendanceModel{EmployeeId = 3, AttendanceTime = DateTime.Now.AddMinutes(13), DepartureTime = DateTime.Now.AddDays(3)},
            new AttendanceModel{EmployeeId = 4, AttendanceTime = DateTime.Now.AddMinutes(14), DepartureTime = DateTime.Now.AddDays(4)},
            new AttendanceModel{EmployeeId = 1, AttendanceTime = DateTime.Now.AddMinutes(15), DepartureTime = DateTime.Now.AddDays(5)},
            new AttendanceModel{EmployeeId = 1, AttendanceTime = DateTime.Now.AddMinutes(16), DepartureTime = DateTime.Now.AddDays(6)},
            new AttendanceModel{EmployeeId = 2, AttendanceTime = DateTime.Now.AddMinutes(17), DepartureTime = DateTime.Now.AddDays(7)},
            new AttendanceModel{EmployeeId = 4, AttendanceTime = DateTime.Now.AddMinutes(18), DepartureTime = DateTime.Now.AddDays(8)},
        };
    }
    public static ObservableCollection<UserModel> GetUsers()
    {
        var users = new Faker<UserModel>().RuleFor(e => e.UserName, f => f.Name.FirstName())
            .RuleFor(e => e.DisplayName, f => f.Name.LastName())
            .RuleFor(e => e.Password, f => new String(f.Random.Chars()))
            .RuleFor(e => e.UserType, f => f.Random.Enum<UserType>()).Generate(3);
        
        return new ObservableCollection<UserModel>(users);
    }
    public static ObservableCollection<ClinicContactModel> GetClinicsContacts()
    {
        return new ObservableCollection<ClinicContactModel> {
                new ClinicContactModel{ClinicId = 1, ContactInfo = "alsharabi@gmail.com", ContactType = ContactType.PrimaryEmail},
                new ClinicContactModel{ClinicId = 1, ContactInfo = "Mohammed@gmail.com", ContactType = ContactType.AlternativeEmail},
                new ClinicContactModel{ClinicId = 1, ContactInfo = "777474834", ContactType = ContactType.PrimaryPhoneNumber},
                new ClinicContactModel{ClinicId = 1, ContactInfo = "01 392123", ContactType = ContactType.AlternativePhoneNumber},
                new ClinicContactModel{ClinicId = 2, ContactInfo = "Khaksl@gmail.com", ContactType = ContactType.PrimaryEmail},
                new ClinicContactModel{ClinicId = 3, ContactInfo = "alksdf@gmail.com", ContactType = ContactType.AlternativeEmail},
                new ClinicContactModel{ClinicId = 2, ContactInfo = "982323", ContactType = ContactType.PrimaryPhoneNumber},
                new ClinicContactModel{ClinicId = 4, ContactInfo = "01 343123", ContactType = ContactType.AlternativePhoneNumber}
            };
    }
}
