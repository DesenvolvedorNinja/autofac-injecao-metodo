using Autofac;
using Autofac.Core;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AutofacDemoWin
{
    public partial class FormAutofacDemoWin : Form
    {
        private IContainer _container;

        public FormAutofacDemoWin()
        {
            InitializeComponent();
        }

        private void FormAutofacDemoWin_Load(object sender, EventArgs e)
        {
            var builder = new ContainerBuilder();
            
            builder.Register(c =>
            {
                var result = new DesenvolvedorNinja();
                var depPrincipal = c.Resolve<ILinguagemProgramacao>();
                var depSecundaria = c.Resolve<LinguagemGO>();
                result.SetLinguagemProgramacao(depPrincipal, depSecundaria);
                return result;
            }).As<IDesenvolvedor>().InstancePerDependency();
            
            /*
            builder.RegisterType<DesenvolvedorNinja>().OnActivating(c => {
                var depPrincipal = c.Context.Resolve<ILinguagemProgramacao>();
                var depSecundaria = c.Context.Resolve<LinguagemGO>();
                c.Instance.SetLinguagemProgramacao(depPrincipal, depSecundaria);
            }).As<IDesenvolvedor>().InstancePerDependency();
            */
            builder.RegisterType<LinguagemCSharp>().As<ILinguagemProgramacao>().AsSelf().InstancePerDependency();
            builder.RegisterType<LinguagemGO>().AsSelf().InstancePerDependency();
            _container = builder.Build();
        }

        private void buttonObterLinguagemAutofac_Click(object sender, EventArgs e)
        {
            IDesenvolvedor desenvolvedor = _container.Resolve<IDesenvolvedor>();
            MessageBox.Show(desenvolvedor.GetLinguagemProgramacao());
        }
    }
}
