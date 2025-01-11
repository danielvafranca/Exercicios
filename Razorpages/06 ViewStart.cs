E tem como eu apliar o Layout para todas as paginas sem precisar especificar:

Cria um item uma pasta chamada _ViewStart.cshtml
( O viewStart vai ser executado junto com todas as views)

eu ai eu posso tirar os
@{
    Layout = "Shared/ Layout";
}

de todas as pagina

e se na pagina já tiver o layout @{} sempre vai sobrescrever o layout do viewStart