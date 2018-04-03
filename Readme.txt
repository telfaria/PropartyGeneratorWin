プロパティ生成ツール
PropartyGenerator for VB.NET by Elfaria

入力ファイルからプロパティを生成します
VB.NET 専用です

入力ファイル形式
CSVファイル 2フィールド
プロパティ名,型 の形式です。

ファイル内容例：
Prop1,String
Prop2,String

出力：
Private _Prop1 As String
Public Property Prop1() As String
Get
    Return _Prop1
End Get
Set(ByVal value As String)
    _Prop1 = value
End Set
End Property

Private _Prop2 As String
Public Property Prop2() As String
Get
    Return _Prop2
End Get
Set(ByVal value As String)
    _Prop2 = value
End Set
End Property

こんなコードを返します。
大量のプロパティを生成するときに助かります。

[Browse...]ボタンでファイル選択画面を開きます。
[Generate!]ボタンでプロパティとか生成します。

[Create with 'sub New()' method]をオンにすると、
クラスのコンストラクタ Sub New()を生成すると思います。

[Add '<CsvColumn(fieldindex:=n)>' Attribute]をオンにすると、
LINQtoCSVを使う際に必要なCSVカラム属性をプロパティに付加します。


[Copy to ClipBoard]をクリックすると、内容をクリップボードにコピーします。


注意：
単にコード生成するだけなので、構文チェック・型チェックは一切行っていません。
インデント処理等はVS側に任せようとしているので、出力されるコードは綺麗ではないです。

内製ツールで出来は甘いのでそこは勘弁してください。

履歴：
2017/4/4  v1.1.0.0
GitHubに公開

2014/4/19 v1.1.0.0
LINQtoCSVの出力に対応

ライセンス
MIT License