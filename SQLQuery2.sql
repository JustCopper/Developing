SELECT p.Издательство, COUNT(*) as total_books
FROM GivenBooks gb
JOIN NewBooks nb ON gb.book_id = nb.book_id
JOIN publishhouses p ON nb.Издательство = p.publishhouse_id
WHERE gb.given_date BETWEEN CONVERT(date, '01.12.2023', 104) AND CONVERT(date, '25.12.2023', 104)
GROUP BY p.Издательство
ORDER BY total_books DESC;
