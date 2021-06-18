using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.EntityFrameworkCore;
using WPF_DB.ViewModels;

namespace WPF_DB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<int> ListaIds = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
            PersistirCadastroCliente();
        }
        
        private void PersistirCadastroCliente()
        {
            using (CCDbContext db = new CCDbContext())
            {
                var CadastroClientesData = db.CadastroCliente.ToList();
                foreach (var item in CadastroClientesData)
                {
                    grid2.Items.Add(item);
                }

            }
        }

        private void AdicionarAListadeItensADeletar(object sender, RoutedEventArgs e)
        {
            CadastroCliente Cc = grid2.SelectedItem as CadastroCliente;
            int idCliente = Cc.IdCliente;
            ListaIds.Add(idCliente);

        }

        private void RemoveDaListadeItensADeletar(object sender, RoutedEventArgs e)
        {
            CadastroCliente Cc = grid2.SelectedItem as CadastroCliente;
            int idCliente = Cc.IdCliente;
            ListaIds.Remove(idCliente);
        }
        private void SalvarCadastroCliente(object sender, RoutedEventArgs e)
        {
            var NomeCliente = nomeCliente.Text;
            var RG = rg.Text;
            var CPF = cpf.Text;
            var Endereco = endereco.Text;
            var Produto = produto.Text;
            var PrecoVenda = precoVenda.Text;
            using (CCDbContext db = new CCDbContext())
            {
                CadastroCliente CadastroCliente = new CadastroCliente()
                {
                    NomeCliente = NomeCliente,
                    RG = RG,
                    CPF = CPF,
                    Endereco = Endereco,
                    Produto = Produto,
                    PrecoVenda = PrecoVenda
                };
                db.CadastroCliente.Add(CadastroCliente);
                db.SaveChanges();
                grid2.Items.Clear();
                PersistirCadastroCliente();

            }
        }

        private void EditarCadastroCliente(object sender, RoutedEventArgs e)
        {
            try
            {
                using (CCDbContext db = new CCDbContext())
                {
                    
                    var CadastroClientesData = db.CadastroCliente.ToList();
                    foreach (int id in ListaIds)
                    {
                        var clienteParaEditar = CadastroClientesData.Select(a => a).Where(c => c.IdCliente == id).First();
                        clienteParaEditar.NomeCliente = nomeCliente.Text;
                        clienteParaEditar.RG= rg.Text;
                        clienteParaEditar.CPF = cpf.Text;
                        clienteParaEditar.Endereco = endereco.Text;
                        clienteParaEditar.Produto = produto.Text;
                        clienteParaEditar.PrecoVenda = precoVenda.Text;
                        db.CadastroCliente.Update(clienteParaEditar);

                    }
                    ListaIds.Clear();
                    db.SaveChanges();
                    grid2.Items.Clear();
                    PersistirCadastroCliente();
                }
            }
            catch
            {
                MessageBox.Show("Não há clientes para deletar");
            }

        }
        private void DeletarCadastroCliente(object sender, RoutedEventArgs e)
        {
            try
            {

                using (CCDbContext db = new CCDbContext())
                {
                    List<CadastroCliente> ClientesParaRemover = new List<CadastroCliente>();
                    var CadastroClientesData = db.CadastroCliente.ToList();
                    foreach (int id in ListaIds)
                    {
                        var clienteParaDeletar = CadastroClientesData.Select(a => a).Where(c => c.IdCliente == id).First();
                        db.CadastroCliente.Remove(clienteParaDeletar);
                        
                    }
                    ListaIds.Clear();
                    db.SaveChanges();
                    grid2.Items.Clear();
                    PersistirCadastroCliente();
                }
            }
            catch
            {
                MessageBox.Show("Não há clientes para deletar");
            }
        }

        private void nomeCliente_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

}




