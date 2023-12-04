SELECT s.Имя, s.Фамилия, s.Отчество, COUNT(*) as [Выдано книг]
FROM GivenBooks g
JOIN Staff s ON g.staff_id = s.staff_id
WHERE g.given_date BETWEEN CONVERT(date, '01.12.2023', 104) AND CONVERT(date, '25.12.2023', 104)
GROUP BY s.Имя, s.Фамилия, s.Отчество
ORDER BY [Выдано книг] DESC;
