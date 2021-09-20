@model DESPman1.Models.Persona

    @{
        ViewBag.Title = "DESP- MAN";
    }
<!DOCTYPE html>

    <head>
        <title>DESP-MAN</title>
        <link href="~/Content/bootstrap.min.css" rel="stylesheet" />
    </head>
    
    
    <h1>DESP-MAN</h1>
    
    @using (Html.BeginForm()) {
        @Html.AntiForgeryToken()
    
<div class="form-horizontal">
    <h4>INICIAR SESIÓN</h4>
    <br />

    @Html.ValidationSummary(true, "", new { @class = "text-danger" })
    @*/HiddenFor --> manda el id oculto*@
    @Html.HiddenFor(model => model.Id)



    <div class="form-group">
        @Html.LabelFor(model => model.Correo, htmlAttributes: new { @class = "control-label col-md-2" })
        <div class="col-md-10">
            @Html.EditorFor(model => model.Correo, new { htmlAttributes = new { @class = "form-control" } })
            @Html.ValidationMessageFor(model => model.Correo, "", new { @class = "text-danger" })
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(model => model.Clave, htmlAttributes: new { @class = "control-label col-md-2" })
        <div class="col-md-10">
            @Html.EditorFor(model => model.Clave, new { htmlAttributes = new { @class = "form-control" } })
            @Html.ValidationMessageFor(model => model.Clave, "", new { @class = "text-danger" })
        </div>
    </div>
    <br />
    <br />
    <div class="d-md-inline">
        <div class="d-grid gap-2 d-md-block">
            <button type="submit" class="btn btn-outline-success">Ingresar</button>
            @Html.ActionLink("Registrase", "Registro", new { id = "" }, new { @class = "btn btn-outline-warning" })
        </div>
    </div>
    @{
        if (ViewData["error"].ToString() != "ok") {
            <div class="m-5 alert alert-danger alert-dismissible fade show" role="alert">
                <strong>@ViewData["error"].ToString()</strong>
                <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>

            </div>
        }

    }

</div>
    }