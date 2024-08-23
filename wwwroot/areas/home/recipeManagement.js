$(document).ready(function() {
    console.log("testing");
})

function showMdlAdd() {
    $("#modalAdd").modal("show");
}

function showDeleteModal(recipeId) {
    // Set the recipe ID in the hidden input
    document.getElementById('deleteRecipeId').value = recipeId;
    // Show the modal
    var deleteModal = new bootstrap.Modal(document.getElementById('modalDelete'), {});
    deleteModal.show();
}

function confirmDelete() {
    // Get the recipe ID from the hidden input
    var recipeId = document.getElementById('deleteRecipeId').value;
    
    // Create a form to submit the delete request
    var form = document.createElement('form');
    form.method = 'post';
    form.action = '/Home/Delete/' + recipeId; // Assuming your Delete action is set up like this
    
    // Append an anti-forgery token to the form
    var token = document.createElement('input');
    token.type = 'hidden';
    token.name = '__RequestVerificationToken';
    token.value = '@Html.AntiForgeryToken()'; // MVC will generate the token
    form.appendChild(token);

    // Append the form to the body and submit it
    document.body.appendChild(form);
    form.submit();
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
