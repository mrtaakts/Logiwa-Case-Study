
# Logiwa-Case-Study

The created web API project CRUD operations for Category and Product Entities.

## Endpoints

### Category Controller
![Swagger_Category](https://user-images.githubusercontent.com/57454282/135446670-1363942f-eb4a-4776-a3f6-7b0ef6632bb5.png)

- /api/Category 
**[HttpGet]**
  > This HttpGet action gets categories
  
- /api/Category 
**[HttpPost]**
  > This HttpPost action creates category
  
- /api/Category
**[HttpPut]**
  > This HttpPut action updates the category
  
- /api/Category/{id}
**[HttpDelete]**
  > This HttpDelete deletes the category by category's ID.
  
- /api/Category/{id}
**[HttpGet]**
  > This HttpGet action gets the category by category's ID.
  
### Product Controller
![Swagger_Product](https://user-images.githubusercontent.com/57454282/135591088-87bf59cd-b610-4ef6-a574-4c8744f837a8.png)

- /api/Product
**[HttpGet]**
  > This HttpGet action gets products
  
- /api/Product
**[HttpPost]**
  > This HttpPost action creates product based on validation rules
  
- /api/Product
**[HttpPut]**
  > This HttpPut action updates the category
  
- /api/Product/{id}
**[HttpDelete]**
  > This HttpDelete deletes the product by product's ID.
  
- /api/Category/{id}
**[HttpGet]**
  > This HttpGet action gets the product by product's ID.

- /api/Category/FilterProduct
**[HttpGet]**
  > This HttpGet action gets list of products by criterias
### Example For FilterProduct

![Example_FilterProduct](https://user-images.githubusercontent.com/57454282/135590767-2b103ae0-9d57-4e31-abb1-96155d7f9f6b.png)

This httpget action returns the filtered list of products. Title, description, category name, minquantity and maxquantity are fields for searching. Each of these fields is optional, one or more of them can be blank.

 ## Seed Data
 
 In order to facilitate the testability of the web api project, seed data code was written for 2 tables in the project. In this way, the project is ready to run and tested.

![seedData](https://user-images.githubusercontent.com/57454282/135469342-fa719717-4be0-424b-9131-d83ff1c54776.png)


## Generic Repository

By writing Generic Service, code duplication was avoided and thus a higher quality and more manageable code was written.

![baseController](https://user-images.githubusercontent.com/57454282/135470055-c500097d-3120-4ca6-aa33-5260836376e1.png)

