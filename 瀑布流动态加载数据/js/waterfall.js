/*
@�汾����: �汾����: 2012��4��11��
@����Ȩ����: 1024 intelligence ( http://www.1024i.com )

���ʹ�ñ��������, �����뱣������Ȩ������Ϣ.
����©�����������, ����ϵ Lou Barnes(iua1024@gmail.com)
*/
$(document).ready(function(){
	loadMore();
});	

$(window).scroll(function(){
	// ����������ײ�����100����ʱ�� ����������
	if ($(document).height() - $(this).scrollTop() - $(this).height()<100) loadMore();
});

 var n = 0;
function loadMore()
{
   
    n++;
      

    $.ajax({
        type: "Get",
        url: '/Demo/SendImage',
        data:{
            pageIndex: n,
            pageSize:4
        },
        dataType: 'json',       
		success : function(json)
		{
		    
			if(typeof json == 'object')
			{
			    
				var oProduct, $row, iHeight, iTempHeight;
				for (var i = 0, l = json.image.length; i < l; i++)
				{
				   
				    oProduct = json.image[i];
					
					// �ҳ���ǰ�߶���С����, ��������ӵ�����
					iHeight = -1;
					$('#stage li').each(function(){
						iTempHeight = Number( $(this).height() );
						if(iHeight==-1 || iHeight>iTempHeight)
						{
							iHeight = iTempHeight;
							$row = $(this);
						}
					});
					
					
					$item = $('<img src="' + oProduct.ImgUrl + '" border="0" ><br />').hide();
					
					$row.append($item);
					$item.fadeIn();
					
				}
			}
			
		}
    });
  
}