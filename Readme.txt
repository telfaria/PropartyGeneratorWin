�v���p�e�B�����c�[��
PropartyGenerator for VB.NET by Elfaria

���̓t�@�C������v���p�e�B�𐶐����܂�
VB.NET ��p�ł�

���̓t�@�C���`��
CSV�t�@�C�� 2�t�B�[���h
�v���p�e�B��,�^ �̌`���ł��B

�t�@�C�����e��F
Prop1,String
Prop2,String

�o�́F
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

����ȃR�[�h��Ԃ��܂��B
��ʂ̃v���p�e�B�𐶐�����Ƃ��ɏ�����܂��B

[Browse...]�{�^���Ńt�@�C���I����ʂ��J���܂��B
[Generate!]�{�^���Ńv���p�e�B�Ƃ��������܂��B

[Create with 'sub New()' method]���I���ɂ���ƁA
�N���X�̃R���X�g���N�^ Sub New()�𐶐�����Ǝv���܂��B

[Add '<CsvColumn(fieldindex:=n)>' Attribute]���I���ɂ���ƁA
LINQtoCSV���g���ۂɕK�v��CSV�J�����������v���p�e�B�ɕt�����܂��B


[Copy to ClipBoard]���N���b�N����ƁA���e���N���b�v�{�[�h�ɃR�s�[���܂��B


���ӁF
�P�ɃR�[�h�������邾���Ȃ̂ŁA�\���`�F�b�N�E�^�`�F�b�N�͈�؍s���Ă��܂���B
�C���f���g��������VS���ɔC���悤�Ƃ��Ă���̂ŁA�o�͂����R�[�h���Y��ł͂Ȃ��ł��B

�����c�[���ŏo���͊Â��̂ł����͊��ق��Ă��������B

�����F
2017/4/4  v1.1.0.0
GitHub�Ɍ��J

2014/4/19 v1.1.0.0
LINQtoCSV�̏o�͂ɑΉ�

���C�Z���X
MIT License