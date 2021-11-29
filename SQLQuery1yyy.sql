select datename(month,PaymentDate) as Month, Sum (Total) as Total From Payment_tbl Where datediff(month, PaymentDate, GETDATE()) <12 Group by month(PaymentDate),datename(month,PaymentDate)
Select cast(PaymentDate as date) as StartMonth , sum(Total) as Total From Payment_tbl where datediff(month, PaymentDate, GETDATE()) <12 Group BY cast(PaymentDate as date) order by StartMonth
select Dateadd(month,PaymentDate) as Month, Sum (Total) as Total From Payment_tbl Where datediff(month, PaymentDate, GETDATE()) <12 Group by month(PaymentDate),dateadd(month,PaymentDate)
select CONVERT(NVARCHAR(7),[