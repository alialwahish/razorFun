using Microsoft.AspNetCore.Mvc;


namespace rasorFun{

public class rasorController: Controller{

[HttpGet]
[Route("")]
public IActionResult index(){
    return View();
}

}



}