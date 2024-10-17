using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MealsManager.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cookbooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cookbooks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CookingStepType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CookingStepType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cuisines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuisines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IngredientCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IngredientUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MealPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    From = table.Column<DateOnly>(type: "date", nullable: false),
                    To = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pantries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pantries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecipeCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IngredientCategoryIngredientCategory",
                columns: table => new
                {
                    ParentCategoriesId = table.Column<int>(type: "int", nullable: false),
                    SubcategoriesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientCategoryIngredientCategory", x => new { x.ParentCategoriesId, x.SubcategoriesId });
                    table.ForeignKey(
                        name: "FK_IngredientCategoryIngredientCategory_IngredientCategories_ParentCategoriesId",
                        column: x => x.ParentCategoriesId,
                        principalTable: "IngredientCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientCategoryIngredientCategory_IngredientCategories_SubcategoriesId",
                        column: x => x.SubcategoriesId,
                        principalTable: "IngredientCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CuisineIngredient",
                columns: table => new
                {
                    CuisinesId = table.Column<int>(type: "int", nullable: false),
                    IngredientsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuisineIngredient", x => new { x.CuisinesId, x.IngredientsId });
                    table.ForeignKey(
                        name: "FK_CuisineIngredient_Cuisines_CuisinesId",
                        column: x => x.CuisinesId,
                        principalTable: "Cuisines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CuisineIngredient_Ingredients_IngredientsId",
                        column: x => x.IngredientsId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IngredientIngredientCategory",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    IngredientsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientIngredientCategory", x => new { x.CategoriesId, x.IngredientsId });
                    table.ForeignKey(
                        name: "FK_IngredientIngredientCategory_IngredientCategories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "IngredientCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientIngredientCategory_Ingredients_IngredientsId",
                        column: x => x.IngredientsId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    NumberOfServings = table.Column<byte>(type: "tinyint", nullable: false),
                    CuisineId = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_Cuisines_CuisineId",
                        column: x => x.CuisineId,
                        principalTable: "Cuisines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recipes_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PantryCategories",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    PantryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PantryCategories", x => new { x.CategoriesId, x.PantryId });
                    table.ForeignKey(
                        name: "FK_PantryCategories_IngredientCategories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "IngredientCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PantryCategories_Pantries_PantryId",
                        column: x => x.PantryId,
                        principalTable: "Pantries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PantryCategoryChildren",
                columns: table => new
                {
                    PantryId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ChildCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PantryCategoryChildren", x => new { x.PantryId, x.CategoryId, x.ChildCategoryId });
                    table.ForeignKey(
                        name: "FK_PantryCategoryChildren_IngredientCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "IngredientCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PantryCategoryChildren_IngredientCategories_ChildCategoryId",
                        column: x => x.ChildCategoryId,
                        principalTable: "IngredientCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PantryCategoryChildren_Pantries_PantryId",
                        column: x => x.PantryId,
                        principalTable: "Pantries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PantryCategoryIngredients",
                columns: table => new
                {
                    PantryId = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    IngredientCategoryId = table.Column<int>(type: "int", nullable: false),
                    IngredientUnitId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PantryCategoryIngredients", x => new { x.PantryId, x.IngredientCategoryId, x.IngredientId, x.IngredientUnitId });
                    table.ForeignKey(
                        name: "FK_PantryCategoryIngredients_IngredientCategories_IngredientCategoryId",
                        column: x => x.IngredientCategoryId,
                        principalTable: "IngredientCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_PantryCategoryIngredients_IngredientUnits_IngredientUnitId",
                        column: x => x.IngredientUnitId,
                        principalTable: "IngredientUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PantryCategoryIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PantryCategoryIngredients_Pantries_PantryId",
                        column: x => x.PantryId,
                        principalTable: "Pantries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CookbookCategories",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    CookbookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CookbookCategories", x => new { x.CategoriesId, x.CookbookId });
                    table.ForeignKey(
                        name: "FK_CookbookCategories_Cookbooks_CookbookId",
                        column: x => x.CookbookId,
                        principalTable: "Cookbooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CookbookCategories_RecipeCategories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "RecipeCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeCategoryRecipeCategory",
                columns: table => new
                {
                    ParentCategoriesId = table.Column<int>(type: "int", nullable: false),
                    SubcategoriesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeCategoryRecipeCategory", x => new { x.ParentCategoriesId, x.SubcategoriesId });
                    table.ForeignKey(
                        name: "FK_RecipeCategoryRecipeCategory_RecipeCategories_ParentCategoriesId",
                        column: x => x.ParentCategoriesId,
                        principalTable: "RecipeCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeCategoryRecipeCategory_RecipeCategories_SubcategoriesId",
                        column: x => x.SubcategoriesId,
                        principalTable: "RecipeCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CookbookCategoryChildren",
                columns: table => new
                {
                    CookbookId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ChildCategoryId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CookbookCategoryChildren", x => new { x.CookbookId, x.CategoryId, x.ChildCategoryId });
                    table.ForeignKey(
                        name: "FK_CookbookCategoryChildren_Cookbooks_CookbookId",
                        column: x => x.CookbookId,
                        principalTable: "Cookbooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CookbookCategoryChildren_RecipeCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "RecipeCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CookbookCategoryChildren_RecipeCategories_ChildCategoryId",
                        column: x => x.ChildCategoryId,
                        principalTable: "RecipeCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CookbookCategoryChildren_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CookbookRecipes",
                columns: table => new
                {
                    CookbookId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CookbookRecipes", x => new { x.CookbookId, x.RecipeId });
                    table.ForeignKey(
                        name: "FK_CookbookRecipes_Cookbooks_CookbookId",
                        column: x => x.CookbookId,
                        principalTable: "Cookbooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CookbookRecipes_RecipeCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "RecipeCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_CookbookRecipes_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CookingSteps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CookingStepTypeId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CookingSteps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CookingSteps_CookingStepType_CookingStepTypeId",
                        column: x => x.CookingStepTypeId,
                        principalTable: "CookingStepType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CookingSteps_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MealPlanRecipe",
                columns: table => new
                {
                    MealPlansId = table.Column<int>(type: "int", nullable: false),
                    RecipesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealPlanRecipe", x => new { x.MealPlansId, x.RecipesId });
                    table.ForeignKey(
                        name: "FK_MealPlanRecipe_MealPlans_MealPlansId",
                        column: x => x.MealPlansId,
                        principalTable: "MealPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MealPlanRecipe_Recipes_RecipesId",
                        column: x => x.RecipesId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeIngredients",
                columns: table => new
                {
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    IngredientUnitId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredients", x => new { x.RecipeId, x.IngredientId, x.IngredientUnitId });
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_IngredientUnits_IngredientUnitId",
                        column: x => x.IngredientUnitId,
                        principalTable: "IngredientUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeRecipeCategory",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    RecipesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeRecipeCategory", x => new { x.CategoriesId, x.RecipesId });
                    table.ForeignKey(
                        name: "FK_RecipeRecipeCategory_RecipeCategories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "RecipeCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeRecipeCategory_Recipes_RecipesId",
                        column: x => x.RecipesId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CookbookCategories_CookbookId",
                table: "CookbookCategories",
                column: "CookbookId");

            migrationBuilder.CreateIndex(
                name: "IX_CookbookCategoryChildren_CategoryId",
                table: "CookbookCategoryChildren",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CookbookCategoryChildren_ChildCategoryId",
                table: "CookbookCategoryChildren",
                column: "ChildCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CookbookCategoryChildren_RecipeId",
                table: "CookbookCategoryChildren",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_CookbookRecipes_CategoryId",
                table: "CookbookRecipes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CookbookRecipes_RecipeId",
                table: "CookbookRecipes",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_CookingSteps_CookingStepTypeId",
                table: "CookingSteps",
                column: "CookingStepTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CookingSteps_RecipeId",
                table: "CookingSteps",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_CuisineIngredient_IngredientsId",
                table: "CuisineIngredient",
                column: "IngredientsId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientCategoryIngredientCategory_SubcategoriesId",
                table: "IngredientCategoryIngredientCategory",
                column: "SubcategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientIngredientCategory_IngredientsId",
                table: "IngredientIngredientCategory",
                column: "IngredientsId");

            migrationBuilder.CreateIndex(
                name: "IX_MealPlanRecipe_RecipesId",
                table: "MealPlanRecipe",
                column: "RecipesId");

            migrationBuilder.CreateIndex(
                name: "IX_PantryCategories_PantryId",
                table: "PantryCategories",
                column: "PantryId");

            migrationBuilder.CreateIndex(
                name: "IX_PantryCategoryChildren_CategoryId",
                table: "PantryCategoryChildren",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PantryCategoryChildren_ChildCategoryId",
                table: "PantryCategoryChildren",
                column: "ChildCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PantryCategoryIngredients_IngredientCategoryId",
                table: "PantryCategoryIngredients",
                column: "IngredientCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PantryCategoryIngredients_IngredientId",
                table: "PantryCategoryIngredients",
                column: "IngredientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PantryCategoryIngredients_IngredientUnitId",
                table: "PantryCategoryIngredients",
                column: "IngredientUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeCategoryRecipeCategory_SubcategoriesId",
                table: "RecipeCategoryRecipeCategory",
                column: "SubcategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_IngredientUnitId",
                table: "RecipeIngredients",
                column: "IngredientUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeRecipeCategory_RecipesId",
                table: "RecipeRecipeCategory",
                column: "RecipesId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CuisineId",
                table: "Recipes",
                column: "CuisineId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_IngredientId",
                table: "Recipes",
                column: "IngredientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CookbookCategories");

            migrationBuilder.DropTable(
                name: "CookbookCategoryChildren");

            migrationBuilder.DropTable(
                name: "CookbookRecipes");

            migrationBuilder.DropTable(
                name: "CookingSteps");

            migrationBuilder.DropTable(
                name: "CuisineIngredient");

            migrationBuilder.DropTable(
                name: "IngredientCategoryIngredientCategory");

            migrationBuilder.DropTable(
                name: "IngredientIngredientCategory");

            migrationBuilder.DropTable(
                name: "MealPlanRecipe");

            migrationBuilder.DropTable(
                name: "PantryCategories");

            migrationBuilder.DropTable(
                name: "PantryCategoryChildren");

            migrationBuilder.DropTable(
                name: "PantryCategoryIngredients");

            migrationBuilder.DropTable(
                name: "RecipeCategoryRecipeCategory");

            migrationBuilder.DropTable(
                name: "RecipeIngredients");

            migrationBuilder.DropTable(
                name: "RecipeRecipeCategory");

            migrationBuilder.DropTable(
                name: "Cookbooks");

            migrationBuilder.DropTable(
                name: "CookingStepType");

            migrationBuilder.DropTable(
                name: "MealPlans");

            migrationBuilder.DropTable(
                name: "IngredientCategories");

            migrationBuilder.DropTable(
                name: "Pantries");

            migrationBuilder.DropTable(
                name: "IngredientUnits");

            migrationBuilder.DropTable(
                name: "RecipeCategories");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Cuisines");

            migrationBuilder.DropTable(
                name: "Ingredients");
        }
    }
}
