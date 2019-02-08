# CookBookAPI
Within this repo contains the database which stores the recipe information that is called upon by the front end web app. Users can access it through search requests and creating references to the API within their profile, but only admins can make changes to the API.

## Database Schema
![dbschema](https://github.com/mbgoseco/CookBookAPI/blob/master/assets/APIDB_SCHEMA.png)

Recipe
- ID (Primary Key)
- Name - Name of each recipe

Ingredients
- RecipeID (Composite Key) - The recipe that this quantity of ingredient is associated to
- IngredientsID (Composite Key) - The ingredient that belongs in a given recipe and its quantity
- Quantity - Amount of each ingredient in a recipe

RecipeIngredients
- ID (Primary Key)
- Name - Name of each ingredient

Instructions
- RecipeID (Composite Key)
- StepNumber (Composite Key) - The number of steps associated with each of their instructions in a given recipe
- Action - The instructions of a specific step in a given recipe

# Sample API Outputs (Swagger)

https://cookbookapi20190205105239.azurewebsites.net/api/Ingredients
![All Ingredients](https://github.com/KKetter/CookBookAPI/blob/master/assets/api-ingredients.jpeg)

https://cookbookapi20190205105239.azurewebsites.net/api/Ingredients/2
![Single Ingredient](https://github.com/KKetter/CookBookAPI/blob/master/assets/api-ingredients-2.jpeg)

https://cookbookapi20190205105239.azurewebsites.net/api/Instructions/2/3
![Single Instruction](https://github.com/KKetter/CookBookAPI/blob/master/assets/api-instructions-2-3.jpeg)

https://cookbookapi20190205105239.azurewebsites.net/api/RecipeIngredients/1/5
![Recipe Ingredient Deletion](https://github.com/KKetter/CookBookAPI/blob/master/assets/api-recipe-ingredients-1-5.jpeg)

https://cookbookapi20190205105239.azurewebsites.net/api/Recipes
![All Recipes](https://github.com/KKetter/CookBookAPI/blob/master/assets/api-recipes.jpeg)