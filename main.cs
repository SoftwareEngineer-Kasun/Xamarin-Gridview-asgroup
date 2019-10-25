var gridview = FindViewById<GridView>(Resource.Id.gridview); 
gridview.Adapter = new ImageAdapter(this); 
gridview.ItemClick += delegate(object sender, 
   AdapterView.ItemClickEventArgs args) { 
      Toast.MakeText(this, 
         args.Position.ToString(), ToastLength.Short).Show(); 
};
