# ChaseMouse      📝Proje Hakkında




## 🛠 Kullanılan Teknolojiler
Oyun Motoru:  Unity 6000.2.9f1

Programlama Dili: C#

Modelleme: Blender (Çevre ve Karakter varlıkları)

Versiyon Kontrol: Git / GitHub

🚀 Kurulum ve Çalıştırma


1. Ön Hazırlık
Bilgisayarınızda Unity 6000.2.9f1 yüklü olduğundan emin olun.


2. Sahneyi Açma
Unity Hub üzerinden projeyi ekleyin ve açın.

Assets > Scenes klasörü içindeki ana sahneye (SampleScene) çift tıklayın.

3. Eksik Referansların Bağlanması (Önemli)
GitHub bazen sahne üzerindeki sürükle-bırak bağlantılarını koparabilir. Eğer oyun düzgün çalışmıyorsa şu kontrolleri yapın:

Karakter Ayarı: Hierarchy'deki karakter objesini seçin. CharacterController scriptindeki Rb kutusuna karakterin kendisini sürükleyip bırakın.

Yol Ayarı (RoadManager): RoadManager objesini seçin. Player kısmına karakteri, Roads listesine ise sahnedeki yol parçalarını (Road, Road 1, 2, 3) sırasıyla ekleyin.

Hız Ayarları: Hızı (Speed) 5 veya 10 olarak ayarlayarak test edin.

🕹 Kontroller
A Tuşu: Sol Şeride Geçiş

D Tuşu: Sağ Şeride Geçiş

📂 Klasör Yapısı
/Assets/Scripts: Karakter ve yol yönetimi kodları.

/Assets/prefab: Hazır yol ve çevre modelleri.

/Assets/karakter: Karakter modeli ve animasyonları.

Bu proje geliştirilmeye devam etmektedir.
