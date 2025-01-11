Temos 2 metodos para sobrescrever quando um componente ou uma PAGINA É INICIALIZADA.
" Assim que um componente for inicializado ele vai chamar este metodo:"

protected override async Task OnInitializedAsync()
{
    await Task.Delay(500)
    for(int i=0; i<25; i++)
    {
        _products.Add(new Product())
    }
}