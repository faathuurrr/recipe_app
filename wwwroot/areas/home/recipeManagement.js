$(document).ready(function() {
    console.log("testing");
})

function showMdlAdd() {
    $("#modalAdd").modal("show");
}

function addIngredient() {
    const ingredientsList = document.getElementById('ingredientsList');
    const newIngredient = document.createElement('div');
    newIngredient.className = 'mb-3';
    newIngredient.innerHTML = '<input type="text" class="form-control" name="Ingredients[]" placeholder="Ingredient" required>';
    ingredientsList.appendChild(newIngredient);
}

function addStep() {
    const stepsList = document.getElementById('stepsList');
    const newStep = document.createElement('div');
    newStep.className = 'mb-3';
    newStep.innerHTML = '<input type="text" class="form-control" name="CookingSteps[]" placeholder="Step" required>';
    stepsList.appendChild(newStep);
}
