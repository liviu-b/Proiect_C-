using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles(); // Serve static files like CSS, JavaScript, images, etc.

app.MapGet("/", async context =>
{
    await context.Response.WriteAsync(@"
        <html>
        <head>
            <title>Coca Cola</title>
            <style>
                /* Navbar styles */
                nav {
                    background-color: #f2f2f2;
                    padding: 10px;
                }

                nav ul {
                    list-style-type: none;
                    margin: 0;
                    padding: 0;
                }

                nav li {
                    display: inline;
                    margin-right: 10px;
                }

                nav a {
                    text-decoration: none;
                    color: #333;
                    font-weight: bold;
                }

                /* Form styles */
                form {
                    margin-top: 20px;
                    text-align: center;
                }

                label {
                    display: block;
                    margin-bottom: 10px;
                }

                input[type='text'] {
                    padding: 5px;
                    width: 200px;
                }

                input[type='checkbox'] {
                    margin-right: 5px;
                }

                input[type='submit'] {
                    padding: 10px 20px;
                    background-color: #333;
                    color: #fff;
                    border: none;
                    cursor: pointer;
                }
            </style>
        </head>
        <body style='background-color:white;'>
            <nav>
                <ul>
                    <li><a href='/'>Home</a></li>
                    <li><a href='/about'>About</a></li>
                    <li><a href='/contact'>Contact</a></li>
                    <li><a href='/careers'>Careers</a></li>
                </ul>
            </nav>
            <img style='border-radius:25px; margin:20px; width: 70vw; text-align: center; margin-left:200px; align-items:center; ' src='./coca-cola.jpeg' alt='Coca Cola' />
            <p style='width: 100vw; padding:50px; margin: auto; text-align:center;  background-color: red; color: white; font-size:20px'> Coca-Cola is one of the most iconic and globally recognized beverage brands. Known for its signature red can and distinctive taste, Coca-Cola has become synonymous with refreshment and enjoyment. With a history dating back over a century, Coca-Cola has consistently delivered a fizzy and uplifting experience to millions of people worldwide. The secret formula, guarded with utmost secrecy, combines a perfect balance of sweetness and carbonation, creating a refreshing and satisfying beverage. Whether enjoyed on its own, paired with a meal, or used as a mixer, Coca-Cola continues to be a beloved choice for moments of celebration, relaxation, and togetherness. Its refreshing taste and timeless appeal have made Coca-Cola a true beverage icon that has stood the test of time.</p>
             <h2 style='font-size: 50px; text-align: center;'>Products</h2>
            <div style='display: flex; flex-wrap: wrap; flex-directions: column; justify-content:center; margin: auto'>
           
            <img style='border-radius:15px; width:25vw;' src='./zero.webp'> 
            <img style='border-radius:25px;  width:25vw;' src='./lime.webp'> 
            <img style='border-radius:15px; width:25vw;' src='./lemon.webp'> 
            </div>
            <p style='width: 100vw; padding:50px; margin: auto; text-align:center; background-color: red; color: white; font-size:20px'>Coca-Cola Zero, Coca-Cola Lemon, and Coca-Cola Lime are exciting variations of the iconic Coca-Cola brand. Offering unique flavors and options, these refreshing beverages provide a twist on the classic Coca-Cola taste. 

Coca-Cola Zero delivers the same great taste as regular Coca-Cola but with zero sugar. It is a perfect choice for those seeking a delicious and satisfying beverage without the calories.

Coca-Cola Lemon combines the refreshing taste of Coca-Cola with a burst of tangy lemon flavor. The zesty citrus notes add an extra level of refreshment, making it a popular choice for those who enjoy a hint of citrus in their beverages.

Coca-Cola Lime offers a delightful fusion of Coca-Cola's classic taste with a hint of refreshing lime. The subtle lime flavor adds a bright and citrusy twist, creating a truly invigorating and unique drinking experience.

Whether you're looking for a zero-sugar option, a zingy lemon twist, or a touch of lime freshness, Coca-Cola Zero, Coca-Cola Lemon, and Coca-Cola Lime offer a variety of choices to suit your taste preferences. Enjoy these flavorful alternatives while still embracing the timeless appeal and quality of the Coca-Cola brand.</p>

            <div style='background-color: red;'>
           <h2 style='text-align:center; color: white; font-size: 35px;'>Contact Us</h2>
            <form style='margin:auto; display: flex; flex-wrap:wrap; flex-direction:row;'>
                 <label style='font-size:25px; margin:30px; color:white; display: block; margin-bottom: 10px;' for='name'>Email:</label>
                <input style='font-size:25px; margin:30px; color:white; padding: 5px; width: 200px;' type='text' id='Email' name='Email'><br><br>
                 <label style='font-size:25px; margin:30px; text-align: center; color:white; display: block; margin-bottom: 10px;' for='name'>Nume:</label>
                <input style='font-size:25px; margin:30px; color:white; padding: 5px; width: 200px;' type='text' id='Nume' name='Nume'><br><br>
                 <label style='font-size:25px; margin:30px; color:white; display: block; margin-bottom: 10px;' for='name'>Prenume:</label>
                <input style='font-size:25px; margin:30px; color:white; padding: 5px; width: 200px;' type='text' id='Prenume' name='Prenume'><br><br>
                
                
                <input style='position:relative; margin-left: 670px; text-align: center; padding: 10px 20px; background-color: #333; color: #fff; border: none; cursor: pointer; padding: 20px;' type='submit' value='Submit'>
            </form>
            </div>
            </div>
          <div style='background-color: #f2f2f2; padding: 20px;'>
  <h1 style='text-align:center; color:#333;'>Information</h1>
  <p style='text-align:center; color:#666;margin-bottom:10px;'><strong>Name:</strong> Coca Cola Company</p>
  <p style='text-align:center; color:#666;margin-bottom:10px;'><strong>Email:</strong> contact@coca.cola.com</p>
  <p style='text-align:center; color:#666;margin-bottom:10px;'><strong>Phone:</strong> +1123-456-7890</p>
  <p style='text-align:center; color:#666;'><strong> Address: </strong>Bucuresti, Piata Romana</p>
</div>
            <div style='display:flex; flex-wrap:wrap; flex-direction:column; margin: 0px; padding: 20px; background-color: black;'>
            <p style='color: white; font-size: 20px; text-align: center;'>2022 The Coca-Cola Company. All Rights Reserved.

We acknowledge the Traditional Owners of country throughout Australia, and acknowledge their continuing connection to land, waters and community. We pay our respects to Elders past, present and emerging.</p>
            </div>
  


            <script src='/scripts.js'></script>
        </body>
</html>
    ");
});
app.MapGet("/about", async context =>
{
    await context.Response.WriteAsync(@"
        <html>
        <head>
            <title>Coca Cola</title>
            <style>
                /* Navbar styles */
                nav {
                    background-color: #f2f2f2;
                    padding: 10px;
                }

                nav ul {
                    list-style-type: none;
                    margin: 0;
                    padding: 0;
                }

                nav li {
                    display: inline;
                    margin-right: 10px;
                }

                nav a {
                    text-decoration: none;
                    color: #333;
                    font-weight: bold;
                }

                /* Content styles */
                .container {
                    max-width: 800px;
                    margin: 0 auto;
                    padding: 40px;
                }

                h1 {
                    font-size: 28px;
                    color: #333;
                    margin-bottom: 20px;
                }

                p {
                    font-size: 16px;
                    line-height: 1.5;
                    color: #555;
                    margin-bottom: 20px;
                }
            </style>
        </head>
        <body style='background-color:white;'>
            <nav>
                <ul>
                    <li><a href='/'>Home</a></li>
                    <li><a href='/about'>About</a></li>
                    <li><a href='/contact'>Contact</a></li>
                     <li><a href='/careers'>Careers</a></li>
                </ul>
            </nav>
            <div class='container'>
                <h1>About the Origin of Coca Cola Company</h1>
    <p>The Coca Cola Company has a rich history that dates back to the late 19th century. It all started in 1886 when a pharmacist named John Pemberton concocted a caramel-colored syrup in a small pharmacy in Atlanta, Georgia. He mixed the syrup with carbonated water to create a refreshing and effervescent drink.</p>
    <p>The initial beverage was named Coca Cola because it was made from the extracts of the coca leaf and the kola nut, which provided a unique flavor and energizing properties. Pemberton believed that his creation had the potential to become a popular soda fountain beverage.</p>
    <p>However, it was Asa Griggs Candler, a businessman with excellent marketing skills, who recognized the true potential of Coca Cola. In 1888, Candler acquired the Coca Cola formula and brand from Pemberton's estate. Under Candler's leadership, the Coca Cola Company began its journey towards becoming a global brand.</p>
    <p>Candler's marketing strategies were groundbreaking for the time. He introduced aggressive advertising campaigns and distributed coupons for free samples of Coca Cola, helping to create widespread awareness and demand for the beverage. The iconic Coca Cola logo, with its distinctive script, was also developed during this period.</p>
    <p>Over the years, the Coca Cola Company expanded its operations, establishing bottling plants across the United States and eventually expanding internationally. The company's commitment to quality and consistency helped it gain a loyal customer base.</p>
    <p>Today, the Coca Cola Company is a multinational corporation with a diverse portfolio of beverages. It has achieved global recognition and is enjoyed by millions of people in more than 200 countries.</p>
    <p><a href='/#'>Go to Home</a></p>
            </div>
        </body>
        </html>
    ");
});
app.MapGet("/contact", async context =>
{
    await context.Response.WriteAsync(@"
        <html>
        <head>
            <title>Contact Us</title>
          
            <style>
                /* Navbar styles */
                nav {
                    background-color: #f2f2f2;
                    padding: 10px;
                }

                nav ul {
                    list-style-type: none;
                    margin: 0;
                    padding: 0;
                }

                nav li {
                    display: inline;
                    margin-right: 10px;
                }

                nav a {
                    text-decoration: none;
                    color: #333;
                    font-weight: bold;
                }

            
                /* Form styles */
                form {
                    margin-top: 20px;
                    text-align: center;
                }

                label {
                    display: block;
                    margin-bottom: 10px;
                }

                input[type='text'] {
                    padding: 5px;
                    width: 200px;
                }

                input[type='checkbox'] {
                    margin-right: 5px;
                }

                input[type='submit'] {
                    padding: 10px 20px;
                    background-color: #333;
                    color: #fff;
                    border: none;
                    cursor: pointer;
                }
            </style>
        </head>
        <body style='background-color: red;'>
        <nav>
                <ul>
                    <li><a href='/'>Home</a></li>
                    <li><a href='/about'>About</a></li>
                    <li><a href='/contact'>Contact</a></li>
                    <li><a href='/careers'>Careers</a></li>
                </ul>
            </nav>
            <h1 style='font-size: 50px; color:white; text-align: center;'>Contact Us</h1>
            <form>
                <label color:white; for='name'><p style='font-size:25px; color: white;'>Name:</p></label>
                <input color:white; type='text' id='name' name='name'><br><br>
                <label color:white; for='email'><p style='font-size:25px; color: white;'>Email:</p></label>
                <input color:white; type='text' id='email' name='email'><br><br>
                <label color:white; for='message'><p style='font-size:25px; color: white;'>Message:</p></label>
                <textarea id='message' name='message' rows='4' cols='50'></textarea><br><br>
                <input style='color:white; margin: 10px;'; type='submit' value='Submit'>
                <div style='margin: 10px; display:flex; flex-wrap:wrap; flex-direction:column; margin: 0px; padding: 20px; background-color: black;'>
            <p style=' margin: 10px; color: white; font-size: 20px; text-align: center;'>2022 The Coca-Cola Company. All Rights Reserved.

We acknowledge the Traditional Owners of country throughout Australia, and acknowledge their continuing connection to land, waters and community. We pay our respects to Elders past, present and emerging.</p>
            </div>
            </form>
        </body>
        </html>
    ");
});
app.MapGet("/careers", async context =>
{
    await context.Response.WriteAsync(@"
        <html>
        <head>
            <title>Careers at Coca Cola</title>
            <style>
      
                /* Navbar styles */
                nav {
                    background-color: #f2f2f2;
                    padding: 10px;
                }

                nav ul {
                    list-style-type: none;
                    margin: 0;
                    padding: 0;
                }

                nav li {
                    display: inline;
                    margin-right: 10px;
                }

                nav a {
                    text-decoration: none;
                    color: #333;
                    font-weight: bold;
                }

            
                /* Header styles */
                header {
                    background-color: #f2f2f2;
                    padding: 10px;
                }

                h1 {
                    color: #333;
                    text-align: center;
                }

                /* Job listing styles */
                .job-listing {
                    margin-bottom: 20px;
                    padding: 10px;
                    border: 1px solid #ccc;
                }

                .job-title {
                    font-weight: bold;
                }

                .job-description {
                    margin-top: 10px;
                }

                /* Footer styles */
                footer {
                    background-color: #f2f2f2;
                    padding: 10px;
                    text-align: center;
                }
            </style>
        </head>
        <body>
        <nav>
                <ul>
                    <li><a href='/'>Home</a></li>
                    <li><a href='/about'>About</a></li>
                    <li><a href='/contact'>Contact</a></li>
                    <li><a href='/careers'>Careers</a></li>
                </ul>
            </nav>
            <header>
                <h1>Careers at Coca Cola</h1>
            </header>

            <div class='job-listing'>
                <h2 class='job-title'>Marketing Specialist</h2>
                <p class='job-description'>We are looking for a talented marketing specialist to join our team. You will be responsible for developing and implementing marketing strategies to promote our products and drive customer engagement.</p>
            </div>

            <div class='job-listing'>
                <h2 class='job-title'>Sales Representative</h2>
                <p class='job-description'>Join our sales team and help us expand our market reach. As a sales representative, you will be responsible for building relationships with clients, identifying new business opportunities, and achieving sales targets.</p>
            </div>

            <div class='job-listing'>
                <h2 class='job-title'>Supply Chain Analyst</h2>
                <p class='job-description'>We are seeking a supply chain analyst to optimize our distribution processes and ensure efficient supply chain operations. You will analyze data, identify bottlenecks, and implement improvements to streamline our supply chain.</p>
            </div>

            <footer>
                <p>2023 Coca Cola. All rights reserved.</p>
            </footer>
        </body>
        </html>
    ");
});
app.Run();




