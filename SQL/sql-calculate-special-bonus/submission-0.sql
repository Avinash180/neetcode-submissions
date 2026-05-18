-- Write your query below
select employee_id,
case when LEFT(name,1) <> 'M' and employee_id % 2 <>0 then salary
else 0 end as bonus from employees 
order by employee_id asc