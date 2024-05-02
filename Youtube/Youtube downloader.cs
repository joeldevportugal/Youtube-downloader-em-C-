using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Youtube
{
    public partial class frYoutube : Form
    {
        private readonly YoutubeClient youtubeClient;

        public frYoutube()
        {
            InitializeComponent();
            youtubeClient = new YoutubeClient();
            CMBMp4.Items.Add("Mp4");
            CMBMp4.SelectedItem = "Mp4";
            CMBMp3.Items.Add("Mp3");
            CMBMp3.SelectedItem = "Mp3";
        }

        private async void BtnMostrar_Click(object sender, EventArgs e)
        {
            await SetQualidades();
        }

        private async Task SetQualidades()
        {
            // URL do vídeo do YouTube
            string videoUrl = txtUrl.Text;
            try
            {
                // Extrair o ID do vídeo da URL
                string videoId = YoutubeExplode.Videos.VideoId.Parse(videoUrl).Value;

                // Obter as qualidades de MP3 e MP4
                string qualityMP3 = await GetQuality(videoId, "MP3");
                string qualityMP4 = await GetQuality(videoId, "MP4");

                // Preencher os ComboBoxes com as qualidades
                CMBMp3.Items.Clear();
                CMBMp3.Items.Add(qualityMP3);
                CMBMp3.SelectedIndex = 0;

                CMBMp4.Items.Clear();
                CMBMp4.Items.Add(qualityMP4);
                CMBMp4.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter informações do vídeo: {ex.Message}");
            }
        }

        private async Task<string> GetQuality(string videoId, string format)
        {
            var streamManifest = await youtubeClient.Videos.Streams.GetManifestAsync(videoId);

            if (format == "MP3")
            {
                var audioStreams = streamManifest.GetAudioOnlyStreams();
                var audioStream = audioStreams.OrderByDescending(s => s.Bitrate).FirstOrDefault();
                double bitrateKbps = (double)audioStream.Bitrate.BitsPerSecond / 1000.0;
                return $"{Math.Round(bitrateKbps, 2)} Kb";
            }
            else if (format == "MP4")
            {
                var videoStreams = streamManifest.GetVideoOnlyStreams();
                var videoStream = videoStreams.FirstOrDefault(s => s.VideoResolution.Height == 360);
                if (videoStream != null)
                    return $"{videoStream.VideoResolution.Height}p";
                else
                    return "360P não disponível";
            }
            else
            {
                return "Formato não suportado";
            }
        }

        private async void BtnDownload_Click(object sender, EventArgs e)
        {
            await DownloadVideoAsync();
        }

        private async Task DownloadVideoAsync()
        {
            // URL do vídeo do YouTube
            string videoUrl = txtUrl.Text;
            try
            {
                // Extrair o ID do vídeo da URL
                string videoId = YoutubeExplode.Videos.VideoId.Parse(videoUrl).Value;

                // Obter as informações do vídeo
                var video = await youtubeClient.Videos.GetAsync(videoId);

                // Exibir um diálogo para selecionar o local e o nome do arquivo
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = video.Title + ".mp4"; // Nome padrão do arquivo
                saveFileDialog.Filter = "Arquivos de vídeo (*.mp4)|*.mp4"; // Filtro para exibir apenas arquivos de vídeo MP4
                saveFileDialog.Title = "Salvar vídeo"; // Título do diálogo

                if (saveFileDialog.ShowDialog() == DialogResult.OK) // Se o usuário selecionou um arquivo e pressionou OK
                {
                    // Obter a URL do vídeo em formato MP4
                    var streamManifest = await youtubeClient.Videos.Streams.GetManifestAsync(videoId);
                    var streamInfo = streamManifest.GetMuxedStreams().FirstOrDefault();
                    if (streamInfo != null)
                    {
                        // Iniciar o progresso da ProgressBar
                        Avanco.Value = 0; // Define o valor inicial da ProgressBar como 0%

                        // Download do vídeo usando a URL obtida
                        await youtubeClient.Videos.Streams.DownloadAsync(streamInfo, saveFileDialog.FileName, new Progress<double>(p =>
                        {
                            // Atualizar o progresso da ProgressBar conforme o download avança
                            Avanco.Value = (int)(p * 100); // Converte o valor do progresso para porcentagem
                        }));

                        // Atualizar a ProgressBar para o valor máximo (100%) após o download ser concluído
                        Avanco.Value = 100;
                        MessageBox.Show("Download concluído com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Vídeo MP4 não disponível.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao fazer o download do vídeo: {ex.Message}");
            }
        }

        private async void BtnExtrair_Click(object sender, EventArgs e)
        {
            await ExtrairAudioAsync();
        }

        private async Task ExtrairAudioAsync()
        {
            // URL do vídeo do YouTube
            string videoUrl = txtUrl.Text;
            try
            {
                // Extrair o ID do vídeo da URL
                string videoId = YoutubeExplode.Videos.VideoId.Parse(videoUrl).Value;

                // Obter as informações do vídeo
                var video = await youtubeClient.Videos.GetAsync(videoId);

                // Exibir um diálogo para selecionar o local e o nome do arquivo
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = video.Title + ".mp3"; // Nome padrão do arquivo
                saveFileDialog.Filter = "Arquivos de áudio (*.mp3)|*.mp3"; // Filtro para exibir apenas arquivos de áudio MP3
                saveFileDialog.Title = "Extrair áudio"; // Título do diálogo

                if (saveFileDialog.ShowDialog() == DialogResult.OK) // Se o usuário selecionou um arquivo e pressionou OK
                {
                    // Obter a URL do áudio em formato MP3
                    var streamManifest = await youtubeClient.Videos.Streams.GetManifestAsync(videoId);
                    var audioStream = streamManifest.GetAudioOnlyStreams().OrderByDescending(s => s.Bitrate).FirstOrDefault();
                    if (audioStream != null)
                    {
                        // Iniciar o progresso da ProgressBar
                        Avanco.Value = 0; // Define o valor inicial da ProgressBar como 0%

                        // Download do áudio usando a URL obtida
                        await youtubeClient.Videos.Streams.DownloadAsync(audioStream, saveFileDialog.FileName, new Progress<double>(p =>
                        {
                            // Atualizar o progresso da ProgressBar conforme o download avança
                            Avanco.Value = (int)(p * 100); // Converte o valor do progresso para porcentagem
                        }));

                        // Atualizar a ProgressBar para o valor máximo (100%) após o download ser concluído
                        Avanco.Value = 100;
                        MessageBox.Show("Extração de áudio concluída com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Áudio MP3 não disponível.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao extrair o áudio: {ex.Message}");
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtUrl.Text = "";
            Avanco.Value = 0;
            CMBMp3.Text = "Mp3";
            CMBMp3.Items.Clear();
            CMBMp4.Text = "Mp4";
            CMBMp4.Items.Clear();
            MessageBox.Show("Limpeza de Dados Feita Com sucesso !...","Limpeza", 
                MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }


        private void BtnSair_Click(object sender, EventArgs e)
        {
          Sair();
        }
        private void Sair()
        {
            if (MessageBox.Show("Deseja Sair do Programa ? Sim/Nao","Sair",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)return;
            MessageBox.Show("A aplicação Vai Fechar dentro de Segundos", "Fechar", 
                MessageBoxButtons.OK,MessageBoxIcon.Warning);
            Application.Exit();
        }
    }
}
