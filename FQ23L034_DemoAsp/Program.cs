using System.Runtime.ConstrainedExecution;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


// créer une page d'accueil, lié au controlleur "Home" (avec lien vers register et un "Bienvenue" qui présente mon site de gestion de contact), une page d'authentification/Register avec login (form) liée au controller Auth, 

//Créer une base de données 2 tables :

//Utilisateur(id, nom, prenom, email, passwd) email est unique et id est auto incrémenté
//Contact (id, nom, prenom, email, datenaiss, tel) id est auto incrémenté
//Faire en utilisant les Html Helpers les formulaires d'enregistrement et de connexion en travaillant avec la DB.