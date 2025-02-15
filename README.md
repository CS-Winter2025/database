# Database Schema and Class Diagram

## Overview

This database is designed to manage an administration structure where managers oversee employees and services. It tracks employees, their schedules, residents, services, and required resources efficiently.

## Relational Schema
### Resident and Personal Info Management

ResidentPersonalInfo( <u>_PersonalInfoId_</u>, Email, Phone, EmergencyContactName, EmergencyContactPhone, EmergencyContactRelationship, FamilyDoctorName, FamilyDoctorPhone, CreatedAt, UpdatedAt)  
Resident( <u>_ResidentId_</u>, Name, <u>_PersonalInfoId_</u>, Status, CreatedAt, UpdatedAt)

### Employee Management

Employee( <u>_EmployeeId_</u>, Name, JobTitle, EmploymentType, PayType, CurrentRate, Status, SocialInsurance, Email, Phone, Address, EmergencyContactName, EmergencyContactPhone, DirectDepositInfo, CreatedAt, UpdatedAt)  
EmployeeManagement( <u>_EmployeeManagementId_</u>, <u>_EmployeeId_</u>, <u>_ManagerId_</u>, StartDate, EndDate)  
EmployeeCertification( <u>_CertificationId_</u>, <u>_EmployeeId_</u>, CertificationType, CertificationNumber, IssueDate, ExpiryDate)

### Asset Management

AssetType( <u>_AssetTypeId_</u>, Name, Description)  
Asset( <u>_AssetId_</u>, <u>_AssetTypeId_</u>, AssetNumber, Status, CurrentRent, Features, CreatedAt, UpdatedAt)  
ResidentAsset( <u>_ResidentId_</u>, <u>_AssetId_</u>, StartDate, EndDate, CurrentRent, Status)  
OccupancyHistory( <u>_OccupancyId_</u>, <u>_AssetId_</u>, <u>_ResidentId_</u>, StartDate, EndDate, MonthlyRent, Status, Notes)  
RentHistory( <u>_RentHistoryId_</u>, <u>_AssetId_</u>, Amount, EffectiveDate, EndDate)

### Service Management

ServiceType( <u>_ServiceTypeId_</u>, Name, Description, DefaultRate, ClientType, MaxGroupSize, RequiredCertifications)  
Service( <u>_ServiceId_</u>, <u>_ServiceTypeId_</u>, Rate, Status)  
ServiceSchedule( <u>_ServiceScheduleId_</u>, <u>_ServiceId_</u>, ScheduleDate, StartTime, EndTime, Status)

### Billing Management

Invoice( <u>_InvoiceId_</u>, <u>_ResidentId_</u>, InvoiceDate, DueDate, TotalAmount, Status, CreatedAt, UpdatedAt)  
InvoiceItem( <u>_InvoiceItemId_</u>, <u>_InvoiceId_</u>, Type, Description, Amount, <u>_ServiceScheduleId_</u>, <u>_OccupancyId_</u>)  
Payment( <u>_PaymentId_</u>, <u>_InvoiceId_</u>, PaymentDate, Amount, PaymentMethod, TransactionReference)

### Maintenance

AssetMaintenance( <u>_MaintenanceId_</u>, <u>_AssetId_</u>, <u>_ReportedBy_</u>, ReportDate, Issue, Status, Resolution, CompletedDate)


## Link to Schema
https://docs.google.com/document/d/1AKiFzbIs_I9TTyrxq0qPIdhcyl2kPkfAl_PKXwbss70/edit?usp=sharing

## Class Diagram
https://drive.google.com/file/d/1we_mWkIEAJs16vf3ULbo1QQzJ40KeIFc/view?usp=drive_link
