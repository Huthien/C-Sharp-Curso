   M S B A M L   `   `   `  ����F  BDataBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:DataBindingDataBinding  5   	       DataBinding.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:DataBinding     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �� .+�5
   
   �� $��Center=�6   $��10q�6-   .��69   (&EJEMPLO DE DATA BINDING CON UN SLIDER:6a   �� 5   
   -   5        $��Texto��5   X   $��50��6M   $��5q�6e   ��6   ��  �� ElementName$
 Slid�� �� Path$ Value� �� Mode$ TwoWay=�6r   �� 5   
   -   5        $
��Slid��5   )   $��20q�6   $	��350��6    � Minimum$ 0Q�65    � Maximum$	 100Q�6A   6Q   �� 5   
   $��10q�6   $��Center=�6   .��69   <:EJEMPLO DE INOTIFYPROPERTYCHANGED CON CAMBIOS EN EL TEXTO:6u   �� 5   
   $��Center=�6   $��10(�6-   .��6;   
Palabra 1:6G   �� 5   
   $	��200��6   $��Center=�6   $��50��6<   ��6H   �� $ Palabra1�$ TwoWay=�6v   �� 5   
   $��Center=�6   $��10(�6-   .��6;   
Palabra 2:6G   �� 5   
   $	��200��6   $��Center=�6   $��50��6<   ��6H   �� $ Palabra2�$ TwoWay=�6v   �� 5   
   $��Center=�6   $��10(�6-   .��6;   Frase:6C   �� 5   
   $	��200��6   $��Center=�6   $��50��6<   ��6H   �� $ Frase_Completa�$ TwoWay=�6|   5      5      