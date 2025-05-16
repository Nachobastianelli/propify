using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]

public class PropertyController : ControllerBase
{
	private readonly IPropertyService _propertyService;
	public PropertyController(IPropertyService propertyService)
	{
		_propertyService = propertyService;
	}

	[HttpGet]
	public ActionResult<List<PropertyDto>> GetAll()
	{
		return _propertyService.GetAll();
	}

	[HttpGet("{id}")]
	public ActionResult<PropertyDto> GetById(int id)
	{
		try
		{
			return _propertyService.GetById(id);
		}
		catch (System.Exception)
		{
			return StatusCode(500, "Propiedad no encontrada");
		}
	}

	[HttpPost]
	public IActionResult Create([FromBody] PropertyCreateRequest request)
	{
		try
		{
			_propertyService.Create(request);
			return Ok();

		}
		catch (System.Exception)
		{
			return StatusCode(500, "La propiedad no ha podido ser creada");
		}
	}

	[HttpPut("{id}")]
	public IActionResult Update([FromRoute] int id, [FromBody] PropertyUpdateRequest request)
	{
		try
		{
			_propertyService.Update(id, request);
			return Ok();
		}
		catch (System.Exception)
		{
			return StatusCode(500, "La propiedad no ha podido ser actualizada");
		}

	}

	[HttpDelete("{id}")]
	public IActionResult Delete([FromRoute] int id)
	{
		try
		{
			_propertyService.Delete(id);
			return Ok();
		}
		catch (System.Exception)
		{
			return StatusCode(500, "La propiedad no ha podido ser eliminada");
		}

	}
}
