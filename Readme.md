# AESTHETIC WINDOWS

[![preview](/preview.png)](https://www.facebook.com/ars103/videos/1246962342124456)

## 원리

두 폼 [Background](/TRUTH/Background.cs) 와 [Truth](/TRUTH/Magnifier.cs) 가 있음

Background 클래스에서 배경 이미지의 절대적 위치를 `ImgLoc` 이란 변수로 공유하고 Truth 클래스에서는 그 위치에 맞게끔 숨겨진 하트의 이미지를 조정함

Truth 폼에서는 `TransparencyKey` 를 `BackColor` 로 했기 때문에 하트를 제외한 다른 부분들은 투명하게 보인다

그래서 저렇게 이미지가 겹쳐지게끔 보인다
