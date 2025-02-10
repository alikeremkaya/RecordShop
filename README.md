# Plak Dükkanı Projesi

Bu proje, bir plak dükkanını yönetmek için geliştirilmiş bir Windows Forms uygulamasıdır. Aşağıda projenin özellikleri, gereksinimleri ve kurulumu hakkında bilgiler bulabilirsiniz.

## Özellikler

- Plak koleksiyonunu yönetme
- Yeni plak ekleme, düzenleme ve silme
- Plak detaylarını görüntüleme
- Plakları farklı kriterlere göre arama
- Kullanıcı yönetimi ve rol bazlı erişim kontrolü

## Gereksinimler

- WindowsForm
- SQL Server veya başka bir uyumlu veritabanı yönetim sistemi
- Visual Studio 2019 veya daha güncel bir sürümü
- Windows işletim sistemi

## Kurulum

1. Bu projeyi kendi bilgisayarınıza klonlayın:
    ```sh
    git clone https://github.com/alikeremkaya/RecordShop.git
    ```

2. Proje dizinine gidin:
    ```sh
    cd RecordShop
    ```

3. Gerekli bağımlılıkları yükleyin:
    ```sh
    dotnet restore
    ```

4. Veritabanı bağlantı ayarlarını yapın:
    - `appsettings.json` dosyasını açın ve veritabanı bağlantı bilgilerini güncelleyin.

5. Veritabanı migrasyonlarını uygulayın:
    ```sh
    dotnet ef database update
    ```

6. Uygulamayı çalıştırın:
    - Visual Studio'yu açın ve projeyi yükleyin.
    - Çözüm Gezgini'nde `PlakDükkanı.sln` dosyasını bulun ve açın.
    - F5 tuşuna basarak uygulamayı çalıştırın.

## Katkıda Bulunma

Katkıda bulunmak için lütfen aşağıdaki adımları izleyin:

1. Bu projeyi forkladıktan sonra kendi branşınızı oluşturun:
    ```sh
    git checkout -b yeni-özellik
    ```

2. Yaptığınız değişiklikleri commitleyin:
    ```sh
    git commit -m "Yeni özellik eklendi"
    ```

3. Branşınıza push edin:
    ```sh
    git push origin yeni-özellik
    ```

4. Bu repoya bir Pull Request oluşturun.

