// in a new class inherited by adapter
public class ImageAdapter : BaseAdapter { 
   Context context; 
   public ImageAdapter(Context ch) {  
      context = ch; 
   } 
      
   public override int Count { 
      get { 
         return cars.Length; 
      } 
   } 
      
   public override long GetItemId(int position) { 
   return 0; 
   } 
      
   public override Java.Lang.Object GetItem(int position) { 
      return null; 
   } 
      
   public override View GetView(int position, 
      View convertView, ViewGroup parent) { 
      ImageView imageView; 
      if (convertView == null) {   
         imageView = new ImageView(context); 
         imageView.LayoutParameters = new GridView.LayoutParams(100, 100); 
         imageView.SetScaleType(ImageView.ScaleType.CenterCrop); 
         imageView.SetPadding(8, 8, 8, 8); 
      } else { 
         imageView = (ImageView)convertView; 
      } 
             
      imageView.SetImageResource(cars[position]); 
      return imageView; 
   } 
   
   int[] cars = { 
      Resource.Drawable.img1, Resource.Drawable.img2, 
      Resource.Drawable.img3, Resource.Drawable.img4, 
      Resource.Drawable.img5, Resource.Drawable.img6, 
   }; 
}            
