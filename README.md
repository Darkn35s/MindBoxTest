MindBoxTest
# Тестовое задание MindBox
В MindBoxTest реализация тестового задания
## SQL запрос
SELECT ProductName, CategoryName FROM Products 
LEFT JOIN ProdAndCateg ON Products.ProductsID=ProdAndCateg.Product 
LEFT JOIN Category ON ProdAndCateg.Category = Category.CategoryID;

Полный скрипт в MindBoxSQLTest
