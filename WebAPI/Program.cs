using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFranework;

var builder = WebApplication.CreateBuilder(args);


//.net'İn IoC containerı
// Add services to the container.
builder.Services.AddSingleton<IProductService,ProductManager>(); //arka planda new ProductManager yapıyor
                                                                 //ProductManager referansı oluşturur.
builder.Services.AddSingleton<IProductDal, EfProductDal>();
builder.Services.AddControllers();





// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
