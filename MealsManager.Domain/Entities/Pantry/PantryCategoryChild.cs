﻿namespace MealsManager.Domain.Entities
{
    public class PantryCategoryChild
    {
        public int PantryId { get; set; }
        public Pantry Pantry { get; set; }

        public int CategoryId { get; set; }
        public IngredientCategory Category { get; set; }

        public int ChildCategoryId { get; set; }
        public IngredientCategory ChildCategory { get; set; }
    }
}
