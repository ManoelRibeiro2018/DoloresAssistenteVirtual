
using CallProject;
using System.Diagnostics;
using TotalVoice;
using TotalVoice.Api;

TotalVoiceClient client = new TotalVoiceClient(Runtime.GetToken);

Tts tts = new Tts(client);

var payload = new
{
    numero_destino = "81983108617",
    mensagem = "Olá, eu sou dolores... Assistente virtual criada por Manoel Ribeiro. tu é uma kenga e lula é ladrão"
};
var response = tts.Enviar(payload);
Debug.WriteLine(response);

