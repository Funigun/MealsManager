# MealsManager
Meals Manager is and API application which allows to manage cookbooks, meal plans, pantry and shopping lists.

## Cookbook model
Cookbooks allows to group receipes together using different types (e.g. cuisine, category).

## Receipe model
Each receipe contains following information (some of them are optional):
- Details (name, description, amount, number of servings, categories, link, macronutrient)
- List of ingredients (these might also be a receipes)
- List of precooking steps (things that usually should be done in advance e.g. preparing a broth which will be used as ingredient)
- List of ingredients preparation steps (steps that are recommended / required to perform before start cooking)
- List of cooking step (actuall receipe)
- List of serving steps (additional instruction (if needed) for putting everything together)

## Pantry model

Pantry model allows to create a list of ingredients that are available in the house.
This can be used for filtering receipes while searching or planning meals for specific period of time.

## Shopping list model

This is simple model which returns list of ingredients based provided details (e.g. ingredients in pantry, receipes).

## Meal Planner model

Meal Planner model can be used to plan meals based on available ingredients or plan shopping with already created plans.
