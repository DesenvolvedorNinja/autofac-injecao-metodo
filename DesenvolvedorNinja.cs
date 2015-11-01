namespace AutofacDemoWin
{
    public class DesenvolvedorNinja : IDesenvolvedor
    {
        public ILinguagemProgramacao LinguagemProgramacao { get; set; }

        public ILinguagemProgramacao LinguagemProgramacaoSecundaria { get; set; }

        public DesenvolvedorNinja()
        {
            
        }

        public string GetLinguagemProgramacao() => $"Linguagem principal: {LinguagemProgramacao.Nome} - Linguagem secundáriaa: {LinguagemProgramacaoSecundaria.Nome}";

        public void SetLinguagemProgramacao(ILinguagemProgramacao linguagemProgramacao, ILinguagemProgramacao linguagemProgramacaoSecundaria)
        {
            LinguagemProgramacao = linguagemProgramacao;
            LinguagemProgramacaoSecundaria = linguagemProgramacaoSecundaria;
        }
    }
}