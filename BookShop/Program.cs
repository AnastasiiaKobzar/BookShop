using BookShop.Data.Interfaces;
using BookShop.Data.Mocks;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddTransient<IAllBooks, MockBooks>();
builder.Services.AddTransient<IBooksCategory, MockCategory>();
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseMvcWithDefaultRoute();
app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

