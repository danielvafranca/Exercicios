// cmd
dotnet new blazorserver -o BlazingShop

pages> _Host:

Criando uma pg
Para criar uma pagina basta criar um arquivo vazio.razor e colocar @page "/nome"

No vnav menu atualizamos: 

// <div class="@NavMenuCssClass" @onclick="ToggleNavMenu">
//     <nav class="flex-column">
//         <div class="nav-item px-3">
//             <NavLink class="nav-link" href="" Match="NavLinkMatch.All">
//                 <span class="oi oi-home" aria-hidden="true"></span> Home
//             </NavLink>
//         </div>
        <div class="nav-item px-3">
            <NavLink class="nav-link" href="products">
                <span class="oi oi-plus" aria-hidden="true"></span> Products
            </NavLink>
        </div>
//         <div class="nav-item px-3">
//             <NavLink class="nav-link" href="fetchdata">
//                 <span class="oi oi-list-rich" aria-hidden="true"></span> Fetch data
//             </NavLink>
//         </div>
//     </nav>
// </div>
