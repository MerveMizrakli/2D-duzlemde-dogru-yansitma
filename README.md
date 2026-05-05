# 2D Geometrik Yansıma Programı (YansitmaProgrami)

Bu proje, 2D düzlemde tanımlanmış bir üçgenin, belirli bir doğru denklemine göre yansımasını (simetriğini) hesaplayan bir C# konsol uygulamasıdır. Lineer cebir ve matris dönüşümleri kullanılarak geometrik dönüşümlerin bilgisayar ortamında nasıl simüle edileceğini gösterir.

## 🚀 Projenin Amacı
Projenin temel amacı, homojen koordinat sistemini kullanarak bir geometrik şeklin (üçgen) verilen bir doğru ekseni üzerinden yansıma matrisini hesaplamak ve yeni koordinatlarını elde etmektir.

## 🛠 Teknik Detaylar
Program içerisinde yer alan `Program.cs` dosyası şu işlemleri gerçekleştirir:

*   **Nokta Tanımlama:** Üçgenin A, B ve C köşe noktaları $3 \times 1$ boyutunda matrisler olarak tanımlanır.
*   **Doğru Denklemi:** Yansıma ekseni olarak `5y = 0.25x + 3.25` denklemi kullanılır. Bu denklemden eğim ($m$) ve y-ekseni kesim noktası ($c$) parametreleri çıkarılır.
*   **Yansıma Matrisi:** `CalculateReflectionMatrix` fonksiyonu ile trigonometrik ve cebirsel formüller kullanılarak $3 \times 3$ boyutunda bir dönüşüm matrisi oluşturulur.
*   **Matris Çarpımı:** Tanımlanan her bir köşe noktası, yansıma matrisi ile çarpılarak (`MultiplyMatrix`) yeni konumları ($A'$, $B'$, $C'$) hesaplanır.

## 💻 Kullanılan Teknolojiler
*   **Dil:** C# (.NET)
*   **Konseptler:** Lineer Cebir, Matris Çarpımı, Homojen Koordinatlar, Bilgisayar Grafiği Temelleri.

## 📊 Örnek Çıktı
Program çalıştırıldığında, orijinal noktaların koordinatlarını ve hesaplanan yansıtılmış noktaların yeni koordinatlarını şu formatta sunar:

```text
Orijinal Noktalar:
A (2.00, 3.00)
B (7.00, 3.00)
...

Yansıtılmış Noktalar:
A' (x.xx, y.yy)
B' (x.xx, y.yy)
