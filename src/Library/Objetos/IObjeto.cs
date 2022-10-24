using System.Collections.Generic;

namespace RoleplayGame
{
  public interface IObjeto  // Usamos interfaces ya que con las clases no podemos realizar herencia múltiple
  {
    int valorAtaque {get; }  
    int valorDefensa {get; }
  }
}
