   M S B A M L   `   `   `  ����L  HCrazyDragonClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CrazyDragonClientCrazyDragonClient  5   	   *    $CrazyDragonClient.RegisterCardWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:CrazyDragonClient     5   	     � Title$  Registrar Cartão��5      $	��350��6$   $	��525��61   .��5	      � .+�5
   
   �� -   5         ��Name$ lbName��5
      $��Nome Impresso��6    $
��Left=�68   $��	31,45,0,0q�6S   $	��Top=�6f   �� 5   
   -   5        $ lbNumber��5      $��Numero��6"   $
��Left=�63   $��	31,76,0,0q�6N   $	��Top=�6a   �� 5   
   -   5        $ 	lbExpDate��5      $��Data Expiração��6#   $
��Left=�6<   $��
31,107,0,0q�6W   $	��Top=�6k   �� 5   
   -   5        $ lbBrand��5      $��Bandeira��6!   $
��Left=�64   $��
31,138,0,0q�6O   $	��Top=�6c   �� 5   
   -   5        $ 
lbPassword��5      $��Senha��6$   $
��Left=�64   $��
31,169,0,0q�6O   $	��Top=�6c   �� 5   
   -   5        $ lbType��5      $
��Tipo��6    $
��Left=�6/   $��
31,200,0,0q�6J   $	��Top=�6^   �� 5   
   -   5        $ 	lbBalance��5      $��Saldo��6#   $
��Left=�63   $��
31,231,0,0q�6N   $	��Top=�6b   �� 5   
   -   5         ��Name$ txtName��5      $
��Left=�6#   $��23��6>   $��
148,45,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��120��6�   �� 5   
   -	   5        $ 	txtNumber��5      $
��Left=�6%   $��23��6@   $��
148,76,0,0q�6L   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   �� 5   
   -
   5        $ 
txtExpDate��5      $
��Left=�6&   $��23��6A   $��148,110,0,0q�6M   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��120��6�   �� 5   
   -   5         ��Name$ cbBrand��5      $
��Left=�6$   $��148,138,0,0q�6?   $	��Top=�6T   $	��120��6l   $��26��6x   .@�5      �� $
��Visa��6   $
��Left=�6*   $	��111��6E   �� 5      $��Master��6   $
��Left=�6,   $	��111��6G   5      G� 5   
   -   5         G�Name$ txtPassword��5      $
��Left=�6+   $��148,169,0,0q�6F   $	��Top=�6[   $	��120��6s   $��26��6   �� 5   
   -   5        $ cbType��5      $
��Left=�6#   $��148,200,0,0q�6>   $	��Top=�6S   $	��120��6k   $��26��6w   .@�5      �� $
��Chip��6   $
��Left=�6*   $	��111��6E   �� 5      $��Tarja Magnética��6   $
��Left=�65   $	��111��6P   5      �� 5   
   -   5        $ 
txtBalance��5      $
��Left=�6&   $��23��6A   $��148,231,0,0q�6M   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��120��6�   �� 5   
   -   5         ��Name$ btnRegister��5      $��	Cadastrar��6&   $
��Left=�6:   $��119,284,0,0q�6U   $	��Top=�6j   $��75��6�   6�   �� 5   
   -   5        $ btnBack��5      $��Voltar��6"   $
��Left=�63   $��280,284,0,0q�6N   $	��Top=�6c   $��75��6{   6�   5$      5%      