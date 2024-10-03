# Overview
Meals Manager is and API application which allows to:
- manage cooking recipes, ingredients, categories (separate for recipes and ingredients) and pantries
- create meal plans
- create shopping lists

# Features

## Recipes management
There few features which are available for recipes besides basic CRUD operations:
### a) Grouping 

Define grouping category to create well organized recipe index (cookbooks) based on categories.

Example grouping:
- [Group] Asian cuisine
  - Sushi
    - [Group] Strir Fry
      - Udon noodles with chicken
      - Rice noodles with ground pork
    - [Group] Snacks
      - Onigiri
     
### b) Filtering 

Filter recipes based on categories, cusines, selected ingredients, ingredients available in pantries.

## Ingredients management
Besides basic CRUD operations it is possible to group ingredients in similar way as recipes so your pantries can be well organized.

You can define grouping category (in the same way as for recipes) to organize your pantries.

## Categories management

Define separate categories for recipes and ingredients. Define your own list of cuisines.

## Pantries management

Create your pantries, so building meal plans or filtering recipes can include the stuff which is available at hand.

## Shopping list

Create list shopping list from different places:
- single recipe
- selected recipes
- recipes included in meal plan

## Meal planner

Create a meal plan for specific period or plan meals for a "meal prep" action.
