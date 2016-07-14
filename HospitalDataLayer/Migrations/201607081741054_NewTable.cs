namespace HospitalDataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accountants",
                c => new
                    {
                        AccountID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        Location = c.String(maxLength: 50),
                        PhoneNumber = c.String(nullable: false),
                        Address = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.AccountID);
            
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        RememberMe = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AdminID);
            
            CreateTable(
                "dbo.AdmitHistories",
                c => new
                    {
                        AdmitID = c.Int(nullable: false, identity: true),
                        BedNumber = c.String(nullable: false, maxLength: 50),
                        Ward = c.String(nullable: false, maxLength: 20),
                        PatientName = c.String(nullable: false),
                        AllotmentDate = c.DateTime(nullable: false),
                        DischargeDate = c.DateTime(nullable: false),
                        department_DepartmentID = c.Int(),
                    })
                .PrimaryKey(t => t.AdmitID)
                .ForeignKey("dbo.Departments", t => t.department_DepartmentID)
                .Index(t => t.department_DepartmentID);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentID = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        DoctorID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        Location = c.String(maxLength: 50),
                        PhoneNumber = c.String(nullable: false),
                        Address = c.String(maxLength: 50),
                        Specilization = c.String(nullable: false, maxLength: 50),
                        department_DepartmentID = c.Int(),
                        OperationHistory_OperationID = c.Int(),
                        Patient_PatientID = c.Int(),
                        Prescreption_PrescreptionID = c.Int(),
                        Report_ReportID = c.Int(),
                    })
                .PrimaryKey(t => t.DoctorID)
                .ForeignKey("dbo.Departments", t => t.department_DepartmentID)
                .ForeignKey("dbo.OperationHistories", t => t.OperationHistory_OperationID)
                .ForeignKey("dbo.Patients", t => t.Patient_PatientID)
                .ForeignKey("dbo.Prescreptions", t => t.Prescreption_PrescreptionID)
                .ForeignKey("dbo.Reports", t => t.Report_ReportID)
                .Index(t => t.department_DepartmentID)
                .Index(t => t.OperationHistory_OperationID)
                .Index(t => t.Patient_PatientID)
                .Index(t => t.Prescreption_PrescreptionID)
                .Index(t => t.Report_ReportID);
            
            CreateTable(
                "dbo.Nurses",
                c => new
                    {
                        NurseID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        Location = c.String(maxLength: 50),
                        PhoneNumber = c.String(nullable: false),
                        department_DepartmentID = c.Int(),
                    })
                .PrimaryKey(t => t.NurseID)
                .ForeignKey("dbo.Departments", t => t.department_DepartmentID)
                .Index(t => t.department_DepartmentID);
            
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        AppointmentID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Time = c.DateTime(nullable: false),
                        PatientName = c.String(nullable: false),
                        DoctorName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.AppointmentID);
            
            CreateTable(
                "dbo.BedAllotments",
                c => new
                    {
                        BedID = c.Int(nullable: false, identity: true),
                        BedNumber = c.String(nullable: false),
                        Ward = c.String(nullable: false, maxLength: 50),
                        PatientName = c.String(nullable: false),
                        AllotmentDate = c.DateTime(nullable: false),
                        DischargeDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BedID);
            
            CreateTable(
                "dbo.Bloodbanks",
                c => new
                    {
                        BloodID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.BloodID);
            
            CreateTable(
                "dbo.Blooddoners",
                c => new
                    {
                        DonerID = c.Int(nullable: false, identity: true),
                        NamePatient = c.String(nullable: false),
                        BloodGroup = c.String(nullable: false, maxLength: 10),
                        Gender = c.String(maxLength: 20),
                        Age = c.Int(nullable: false),
                        LastDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.DonerID);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        InvoiceID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        Amount = c.Double(nullable: false),
                        PatientName = c.String(nullable: false),
                        Date = c.String(),
                        Status = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.InvoiceID);
            
            CreateTable(
                "dbo.LaboratoryOperators",
                c => new
                    {
                        LaboratoryID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        Location = c.String(maxLength: 50),
                        PhoneNumber = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.LaboratoryID);
            
            CreateTable(
                "dbo.OperationHistories",
                c => new
                    {
                        OperationID = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OperationID);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        Gender = c.String(maxLength: 20),
                        BirthDate = c.String(),
                        Age = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                        Location = c.String(maxLength: 50),
                        BloodGroup = c.String(maxLength: 10),
                        RelativeNumber = c.String(maxLength: 20),
                        ImageUrl = c.String(maxLength: 255),
                        OperationHistory_OperationID = c.Int(),
                        Prescreption_PrescreptionID = c.Int(),
                        Report_ReportID = c.Int(),
                    })
                .PrimaryKey(t => t.PatientID)
                .ForeignKey("dbo.OperationHistories", t => t.OperationHistory_OperationID)
                .ForeignKey("dbo.Prescreptions", t => t.Prescreption_PrescreptionID)
                .ForeignKey("dbo.Reports", t => t.Report_ReportID)
                .Index(t => t.OperationHistory_OperationID)
                .Index(t => t.Prescreption_PrescreptionID)
                .Index(t => t.Report_ReportID);
            
            CreateTable(
                "dbo.Pharmacists",
                c => new
                    {
                        PharmacistID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        Location = c.String(maxLength: 50),
                        PhoneNumber = c.String(nullable: false),
                        Address = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.PharmacistID);
            
            CreateTable(
                "dbo.Prescreptions",
                c => new
                    {
                        PrescreptionID = c.Int(nullable: false, identity: true),
                        CaseHostory = c.String(nullable: false, maxLength: 50),
                        Medication = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PrescreptionID);
            
            CreateTable(
                "dbo.Receptionists",
                c => new
                    {
                        ReceptionistID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ReceptionistID);
            
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        ReportID = c.Int(nullable: false, identity: true),
                        Type = c.String(maxLength: 50),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReportID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Patients", "Report_ReportID", "dbo.Reports");
            DropForeignKey("dbo.Doctors", "Report_ReportID", "dbo.Reports");
            DropForeignKey("dbo.Patients", "Prescreption_PrescreptionID", "dbo.Prescreptions");
            DropForeignKey("dbo.Doctors", "Prescreption_PrescreptionID", "dbo.Prescreptions");
            DropForeignKey("dbo.Patients", "OperationHistory_OperationID", "dbo.OperationHistories");
            DropForeignKey("dbo.Doctors", "Patient_PatientID", "dbo.Patients");
            DropForeignKey("dbo.Doctors", "OperationHistory_OperationID", "dbo.OperationHistories");
            DropForeignKey("dbo.Nurses", "department_DepartmentID", "dbo.Departments");
            DropForeignKey("dbo.Doctors", "department_DepartmentID", "dbo.Departments");
            DropForeignKey("dbo.AdmitHistories", "department_DepartmentID", "dbo.Departments");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Patients", new[] { "Report_ReportID" });
            DropIndex("dbo.Patients", new[] { "Prescreption_PrescreptionID" });
            DropIndex("dbo.Patients", new[] { "OperationHistory_OperationID" });
            DropIndex("dbo.Nurses", new[] { "department_DepartmentID" });
            DropIndex("dbo.Doctors", new[] { "Report_ReportID" });
            DropIndex("dbo.Doctors", new[] { "Prescreption_PrescreptionID" });
            DropIndex("dbo.Doctors", new[] { "Patient_PatientID" });
            DropIndex("dbo.Doctors", new[] { "OperationHistory_OperationID" });
            DropIndex("dbo.Doctors", new[] { "department_DepartmentID" });
            DropIndex("dbo.AdmitHistories", new[] { "department_DepartmentID" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Reports");
            DropTable("dbo.Receptionists");
            DropTable("dbo.Prescreptions");
            DropTable("dbo.Pharmacists");
            DropTable("dbo.Patients");
            DropTable("dbo.OperationHistories");
            DropTable("dbo.LaboratoryOperators");
            DropTable("dbo.Invoices");
            DropTable("dbo.Blooddoners");
            DropTable("dbo.Bloodbanks");
            DropTable("dbo.BedAllotments");
            DropTable("dbo.Appointments");
            DropTable("dbo.Nurses");
            DropTable("dbo.Doctors");
            DropTable("dbo.Departments");
            DropTable("dbo.AdmitHistories");
            DropTable("dbo.Admins");
            DropTable("dbo.Accountants");
        }
    }
}
