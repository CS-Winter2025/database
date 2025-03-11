# Database Schema and Class Diagram

## Overview

This database is designed to manage an administration structure where managers oversee employees and services. It tracks employees, their schedules, residents, services, and required resources efficiently.

## Relational Schema
### Resident and Personal Info Management

Resident( <u>_ResidentId_</u>, Name, DetailsJson )

### Employee Management

Employee( <u>_EmployeeId_</u>, Name, JobTitle, EmploymentType, PayRate, ManagerId, OrganizationId, DetailsJson )
EmployeeAvailability( <u>_EmployeeId, EventScheduleId_</u> )
EmployeeHoursWorked( <u>_EmployeeId, EventScheduleId_</u> )
EmployeeCertification( <u>_EmployeeId, CertificationType_</u> )
Organization( <u>_OrganizationId_</u>, DetailsJson )

### Asset Management

Asset( <u>_AssetId_</u>, Type, ResidentId, DetailsJson )
ResidentAsset( <u>_ResidentId, AssetId_</u>, StartDate, EndDate, Status, CurrentRent )

### Service Management

Service( <u>_ServiceId_</u>, Type, Rate, DetailsJson )
EmployeeService( <u>_EmployeeId, ServiceId_</u> ) 
ResidentService( <u>_ResidentId, ServiceId_</u> )

### Billing Management

Invoice( <u>_InvoiceId_</u>, ResidentId, Date, AmountDue, AmountPaid )

### Event Scheduling

EventSchedule( <u>_EventScheduleId_</u>, EmployeeId, ServiceId, StartDate, EndDate, RangeOfHours, RepeatPattern )

## Link to Schema
https://docs.google.com/document/d/1AKiFzbIs_I9TTyrxq0qPIdhcyl2kPkfAl_PKXwbss70/edit?usp=sharing

## Class Diagram
https://drive.google.com/file/d/1we_mWkIEAJs16vf3ULbo1QQzJ40KeIFc/view?usp=drive_link
