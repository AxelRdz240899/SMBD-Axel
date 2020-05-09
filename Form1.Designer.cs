namespace Proyecto_Archivos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Pestañas = new System.Windows.Forms.TabControl();
            this.Pestaña_Entidades = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Cabecera = new System.Windows.Forms.Label();
            this.TextB_NuevoNombEnt = new System.Windows.Forms.TextBox();
            this.TextB_NombreActualEnt = new System.Windows.Forms.TextBox();
            this.LB_Mod_NuevoNombre = new System.Windows.Forms.Label();
            this.LB_Mod_NombreActual = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ComboB_AccionesEntidad = new System.Windows.Forms.ComboBox();
            this.DGV_Entidades = new System.Windows.Forms.DataGridView();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEntidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion_Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_Atrib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_Dato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_Siguiente_Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextB_NombreEntidad = new System.Windows.Forms.TextBox();
            this.LB_NombreEntidad = new System.Windows.Forms.Label();
            this.Pestaña_Atributos = new System.Windows.Forms.TabPage();
            this.LB_AccionAtributo = new System.Windows.Forms.Label();
            this.CB_TipoLlave = new System.Windows.Forms.ComboBox();
            this.LB_TipoLlave = new System.Windows.Forms.Label();
            this.BT_BusquedaAtributo = new System.Windows.Forms.Button();
            this.ComboB_AccionesAtributos = new System.Windows.Forms.ComboBox();
            this.BT_AgregarAtributo = new System.Windows.Forms.Button();
            this.LB_EntidadAtributo = new System.Windows.Forms.Label();
            this.ComboB_EntidadAtributo = new System.Windows.Forms.ComboBox();
            this.LB_TipoIndiceAtributo = new System.Windows.Forms.Label();
            this.ComboB_TipoIndiceAtributo = new System.Windows.Forms.ComboBox();
            this.LB_LongitudAtributo = new System.Windows.Forms.Label();
            this.TextB_LongitudAtributo = new System.Windows.Forms.TextBox();
            this.LB_NombreAtributo = new System.Windows.Forms.Label();
            this.ComboB_TipoAtributo = new System.Windows.Forms.ComboBox();
            this.TextB_NombreAtributo = new System.Windows.Forms.TextBox();
            this.DGV_Atributos = new System.Windows.Forms.DataGridView();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAtributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoIndice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_Atributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Llave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_Indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_Sig_Atrib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pestaña_Registros = new System.Windows.Forms.TabPage();
            this.BT_LimpiarDGVAtributosRegistro = new System.Windows.Forms.Button();
            this.BT_EliminarRegistro = new System.Windows.Forms.Button();
            this.BT_ModificarRegistro = new System.Windows.Forms.Button();
            this.BT_AgregarRegistro = new System.Windows.Forms.Button();
            this.DGV_AtributosRegistro = new System.Windows.Forms.DataGridView();
            this.DGV_Registros = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboB_EntidadRegistros = new System.Windows.Forms.ComboBox();
            this.Pestaña_Indices = new System.Windows.Forms.TabPage();
            this.DGV_CajonIndiceSecundario = new System.Windows.Forms.DataGridView();
            this.DireccionCSecundario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LB_EntidadIndice = new System.Windows.Forms.Label();
            this.LB_IndiceSecundario = new System.Windows.Forms.Label();
            this.LB_IndicePrimario = new System.Windows.Forms.Label();
            this.DGV_BloquePrincipalIndiceSecundario = new System.Windows.Forms.DataGridView();
            this.LlaveSecundaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionCajonSecundario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_IndicePrimario = new System.Windows.Forms.DataGridView();
            this.Llave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pestaña_ArbolPrimario = new System.Windows.Forms.TabPage();
            this.DGV_ArbolPrimarioBloquePrincipal = new System.Windows.Forms.DataGridView();
            this.TipoNArbolP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirN_ArbolP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ap1ArbolP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K1ArbolP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ap2ArbolP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K2ArbolP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ap3ArbolP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K3ArbolP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ap4ArbolP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K4ArbolP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pestaña_ArbolSecundario = new System.Windows.Forms.TabPage();
            this.DGV_ArbolSSecundario = new System.Windows.Forms.DataGridView();
            this.Dir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_ArbolSecundario = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pestaña_Relaciones = new System.Windows.Forms.TabPage();
            this.LB_EntidadRelaciones = new System.Windows.Forms.Label();
            this.ComboB_EntidadRelaciones = new System.Windows.Forms.ComboBox();
            this.DGV_Relaciones = new System.Windows.Forms.DataGridView();
            this.ColumnaTablaHijo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaAtributoHijo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaTablaPadre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaAtributoTablaPadre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NuevoArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pestañas.SuspendLayout();
            this.Pestaña_Entidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Entidades)).BeginInit();
            this.Pestaña_Atributos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Atributos)).BeginInit();
            this.Pestaña_Registros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AtributosRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Registros)).BeginInit();
            this.Pestaña_Indices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CajonIndiceSecundario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BloquePrincipalIndiceSecundario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_IndicePrimario)).BeginInit();
            this.Pestaña_ArbolPrimario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ArbolPrimarioBloquePrincipal)).BeginInit();
            this.Pestaña_ArbolSecundario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ArbolSSecundario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ArbolSecundario)).BeginInit();
            this.Pestaña_Relaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Relaciones)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pestañas
            // 
            this.Pestañas.Controls.Add(this.Pestaña_Entidades);
            this.Pestañas.Controls.Add(this.Pestaña_Atributos);
            this.Pestañas.Controls.Add(this.Pestaña_Registros);
            this.Pestañas.Controls.Add(this.Pestaña_Indices);
            this.Pestañas.Controls.Add(this.Pestaña_ArbolPrimario);
            this.Pestañas.Controls.Add(this.Pestaña_ArbolSecundario);
            this.Pestañas.Controls.Add(this.Pestaña_Relaciones);
            this.Pestañas.Location = new System.Drawing.Point(12, 27);
            this.Pestañas.Name = "Pestañas";
            this.Pestañas.SelectedIndex = 0;
            this.Pestañas.Size = new System.Drawing.Size(1014, 559);
            this.Pestañas.TabIndex = 0;
            // 
            // Pestaña_Entidades
            // 
            this.Pestaña_Entidades.Controls.Add(this.label1);
            this.Pestaña_Entidades.Controls.Add(this.LB_Cabecera);
            this.Pestaña_Entidades.Controls.Add(this.TextB_NuevoNombEnt);
            this.Pestaña_Entidades.Controls.Add(this.TextB_NombreActualEnt);
            this.Pestaña_Entidades.Controls.Add(this.LB_Mod_NuevoNombre);
            this.Pestaña_Entidades.Controls.Add(this.LB_Mod_NombreActual);
            this.Pestaña_Entidades.Controls.Add(this.button1);
            this.Pestaña_Entidades.Controls.Add(this.ComboB_AccionesEntidad);
            this.Pestaña_Entidades.Controls.Add(this.DGV_Entidades);
            this.Pestaña_Entidades.Controls.Add(this.TextB_NombreEntidad);
            this.Pestaña_Entidades.Controls.Add(this.LB_NombreEntidad);
            this.Pestaña_Entidades.Location = new System.Drawing.Point(4, 22);
            this.Pestaña_Entidades.Name = "Pestaña_Entidades";
            this.Pestaña_Entidades.Padding = new System.Windows.Forms.Padding(3);
            this.Pestaña_Entidades.Size = new System.Drawing.Size(1006, 533);
            this.Pestaña_Entidades.TabIndex = 0;
            this.Pestaña_Entidades.Text = "Entidades";
            this.Pestaña_Entidades.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            // 
            // LB_Cabecera
            // 
            this.LB_Cabecera.AutoSize = true;
            this.LB_Cabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Cabecera.Location = new System.Drawing.Point(481, 33);
            this.LB_Cabecera.Name = "LB_Cabecera";
            this.LB_Cabecera.Size = new System.Drawing.Size(0, 20);
            this.LB_Cabecera.TabIndex = 9;
            // 
            // TextB_NuevoNombEnt
            // 
            this.TextB_NuevoNombEnt.Location = new System.Drawing.Point(722, 44);
            this.TextB_NuevoNombEnt.Name = "TextB_NuevoNombEnt";
            this.TextB_NuevoNombEnt.Size = new System.Drawing.Size(151, 20);
            this.TextB_NuevoNombEnt.TabIndex = 8;
            // 
            // TextB_NombreActualEnt
            // 
            this.TextB_NombreActualEnt.Location = new System.Drawing.Point(722, 14);
            this.TextB_NombreActualEnt.Name = "TextB_NombreActualEnt";
            this.TextB_NombreActualEnt.Size = new System.Drawing.Size(151, 20);
            this.TextB_NombreActualEnt.TabIndex = 7;
            // 
            // LB_Mod_NuevoNombre
            // 
            this.LB_Mod_NuevoNombre.AutoSize = true;
            this.LB_Mod_NuevoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Mod_NuevoNombre.Location = new System.Drawing.Point(619, 45);
            this.LB_Mod_NuevoNombre.Name = "LB_Mod_NuevoNombre";
            this.LB_Mod_NuevoNombre.Size = new System.Drawing.Size(100, 16);
            this.LB_Mod_NuevoNombre.TabIndex = 6;
            this.LB_Mod_NuevoNombre.Text = "Nuevo Nombre";
            // 
            // LB_Mod_NombreActual
            // 
            this.LB_Mod_NombreActual.AutoSize = true;
            this.LB_Mod_NombreActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Mod_NombreActual.Location = new System.Drawing.Point(619, 18);
            this.LB_Mod_NombreActual.Name = "LB_Mod_NombreActual";
            this.LB_Mod_NombreActual.Size = new System.Drawing.Size(97, 16);
            this.LB_Mod_NombreActual.TabIndex = 5;
            this.LB_Mod_NombreActual.Text = "Nombre Actual";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ejecutar Acción";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ComboB_AccionesEntidad
            // 
            this.ComboB_AccionesEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboB_AccionesEntidad.FormattingEnabled = true;
            this.ComboB_AccionesEntidad.Items.AddRange(new object[] {
            "Agregar Entidad",
            "Eliminar Entidad",
            "Modificar Entidad"});
            this.ComboB_AccionesEntidad.Location = new System.Drawing.Point(173, 35);
            this.ComboB_AccionesEntidad.Name = "ComboB_AccionesEntidad";
            this.ComboB_AccionesEntidad.Size = new System.Drawing.Size(121, 21);
            this.ComboB_AccionesEntidad.Sorted = true;
            this.ComboB_AccionesEntidad.TabIndex = 3;
            this.ComboB_AccionesEntidad.SelectedIndexChanged += new System.EventHandler(this.ComboB_AccionesEntidad_SelectedIndexChanged);
            // 
            // DGV_Entidades
            // 
            this.DGV_Entidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Entidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificador,
            this.NombreEntidad,
            this.Direccion_Entidad,
            this.Dir_Atrib,
            this.Dir_Dato,
            this.Dir_Siguiente_Entidad});
            this.DGV_Entidades.Location = new System.Drawing.Point(15, 78);
            this.DGV_Entidades.Name = "DGV_Entidades";
            this.DGV_Entidades.ReadOnly = true;
            this.DGV_Entidades.Size = new System.Drawing.Size(976, 433);
            this.DGV_Entidades.TabIndex = 2;
            // 
            // Identificador
            // 
            this.Identificador.HeaderText = "Clave";
            this.Identificador.Name = "Identificador";
            this.Identificador.ReadOnly = true;
            // 
            // NombreEntidad
            // 
            this.NombreEntidad.HeaderText = "Nombre";
            this.NombreEntidad.Name = "NombreEntidad";
            this.NombreEntidad.ReadOnly = true;
            // 
            // Direccion_Entidad
            // 
            this.Direccion_Entidad.HeaderText = "Dirección_Ent";
            this.Direccion_Entidad.Name = "Direccion_Entidad";
            this.Direccion_Entidad.ReadOnly = true;
            // 
            // Dir_Atrib
            // 
            this.Dir_Atrib.HeaderText = "Dir_Atributo";
            this.Dir_Atrib.Name = "Dir_Atrib";
            this.Dir_Atrib.ReadOnly = true;
            // 
            // Dir_Dato
            // 
            this.Dir_Dato.HeaderText = "Dir_Dato";
            this.Dir_Dato.Name = "Dir_Dato";
            this.Dir_Dato.ReadOnly = true;
            // 
            // Dir_Siguiente_Entidad
            // 
            this.Dir_Siguiente_Entidad.HeaderText = "Dir_Sig_Ent";
            this.Dir_Siguiente_Entidad.Name = "Dir_Siguiente_Entidad";
            this.Dir_Siguiente_Entidad.ReadOnly = true;
            // 
            // TextB_NombreEntidad
            // 
            this.TextB_NombreEntidad.Location = new System.Drawing.Point(24, 36);
            this.TextB_NombreEntidad.Name = "TextB_NombreEntidad";
            this.TextB_NombreEntidad.Size = new System.Drawing.Size(143, 20);
            this.TextB_NombreEntidad.TabIndex = 1;
            // 
            // LB_NombreEntidad
            // 
            this.LB_NombreEntidad.AutoSize = true;
            this.LB_NombreEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NombreEntidad.Location = new System.Drawing.Point(38, 15);
            this.LB_NombreEntidad.Name = "LB_NombreEntidad";
            this.LB_NombreEntidad.Size = new System.Drawing.Size(124, 20);
            this.LB_NombreEntidad.TabIndex = 0;
            this.LB_NombreEntidad.Text = "Nombre Entidad";
            // 
            // Pestaña_Atributos
            // 
            this.Pestaña_Atributos.Controls.Add(this.LB_AccionAtributo);
            this.Pestaña_Atributos.Controls.Add(this.CB_TipoLlave);
            this.Pestaña_Atributos.Controls.Add(this.LB_TipoLlave);
            this.Pestaña_Atributos.Controls.Add(this.BT_BusquedaAtributo);
            this.Pestaña_Atributos.Controls.Add(this.ComboB_AccionesAtributos);
            this.Pestaña_Atributos.Controls.Add(this.BT_AgregarAtributo);
            this.Pestaña_Atributos.Controls.Add(this.LB_EntidadAtributo);
            this.Pestaña_Atributos.Controls.Add(this.ComboB_EntidadAtributo);
            this.Pestaña_Atributos.Controls.Add(this.LB_TipoIndiceAtributo);
            this.Pestaña_Atributos.Controls.Add(this.ComboB_TipoIndiceAtributo);
            this.Pestaña_Atributos.Controls.Add(this.LB_LongitudAtributo);
            this.Pestaña_Atributos.Controls.Add(this.TextB_LongitudAtributo);
            this.Pestaña_Atributos.Controls.Add(this.LB_NombreAtributo);
            this.Pestaña_Atributos.Controls.Add(this.ComboB_TipoAtributo);
            this.Pestaña_Atributos.Controls.Add(this.TextB_NombreAtributo);
            this.Pestaña_Atributos.Controls.Add(this.DGV_Atributos);
            this.Pestaña_Atributos.Location = new System.Drawing.Point(4, 22);
            this.Pestaña_Atributos.Name = "Pestaña_Atributos";
            this.Pestaña_Atributos.Padding = new System.Windows.Forms.Padding(3);
            this.Pestaña_Atributos.Size = new System.Drawing.Size(1006, 533);
            this.Pestaña_Atributos.TabIndex = 1;
            this.Pestaña_Atributos.Text = "Atributos";
            this.Pestaña_Atributos.UseVisualStyleBackColor = true;
            // 
            // LB_AccionAtributo
            // 
            this.LB_AccionAtributo.AutoSize = true;
            this.LB_AccionAtributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_AccionAtributo.Location = new System.Drawing.Point(542, 33);
            this.LB_AccionAtributo.Name = "LB_AccionAtributo";
            this.LB_AccionAtributo.Size = new System.Drawing.Size(57, 20);
            this.LB_AccionAtributo.TabIndex = 16;
            this.LB_AccionAtributo.Text = "Acción";
            // 
            // CB_TipoLlave
            // 
            this.CB_TipoLlave.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CB_TipoLlave.FormattingEnabled = true;
            this.CB_TipoLlave.Items.AddRange(new object[] {
            "P(Llave Primaria)",
            "S(Llave Secundaria)",
            "N(Ninguna Llave)"});
            this.CB_TipoLlave.Location = new System.Drawing.Point(365, 56);
            this.CB_TipoLlave.Name = "CB_TipoLlave";
            this.CB_TipoLlave.Size = new System.Drawing.Size(121, 21);
            this.CB_TipoLlave.TabIndex = 15;
            this.CB_TipoLlave.SelectedIndexChanged += new System.EventHandler(this.CB_TipoLlave_SelectedIndexChanged);
            // 
            // LB_TipoLlave
            // 
            this.LB_TipoLlave.AutoSize = true;
            this.LB_TipoLlave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TipoLlave.Location = new System.Drawing.Point(380, 33);
            this.LB_TipoLlave.Name = "LB_TipoLlave";
            this.LB_TipoLlave.Size = new System.Drawing.Size(80, 20);
            this.LB_TipoLlave.TabIndex = 14;
            this.LB_TipoLlave.Text = "Tipo Llave";
            // 
            // BT_BusquedaAtributo
            // 
            this.BT_BusquedaAtributo.Location = new System.Drawing.Point(18, 84);
            this.BT_BusquedaAtributo.Name = "BT_BusquedaAtributo";
            this.BT_BusquedaAtributo.Size = new System.Drawing.Size(100, 23);
            this.BT_BusquedaAtributo.TabIndex = 13;
            this.BT_BusquedaAtributo.Text = "Busqueda";
            this.BT_BusquedaAtributo.UseVisualStyleBackColor = true;
            this.BT_BusquedaAtributo.Click += new System.EventHandler(this.BT_BusquedaAtributo_Click);
            // 
            // ComboB_AccionesAtributos
            // 
            this.ComboB_AccionesAtributos.FormattingEnabled = true;
            this.ComboB_AccionesAtributos.Items.AddRange(new object[] {
            "Agregar Atributo",
            "Modificar Atributo",
            "Eliminar Atributo"});
            this.ComboB_AccionesAtributos.Location = new System.Drawing.Point(517, 57);
            this.ComboB_AccionesAtributos.Name = "ComboB_AccionesAtributos";
            this.ComboB_AccionesAtributos.Size = new System.Drawing.Size(108, 21);
            this.ComboB_AccionesAtributos.TabIndex = 12;
            // 
            // BT_AgregarAtributo
            // 
            this.BT_AgregarAtributo.Location = new System.Drawing.Point(631, 54);
            this.BT_AgregarAtributo.Name = "BT_AgregarAtributo";
            this.BT_AgregarAtributo.Size = new System.Drawing.Size(108, 23);
            this.BT_AgregarAtributo.TabIndex = 10;
            this.BT_AgregarAtributo.Text = "Ejecutar Acción";
            this.BT_AgregarAtributo.UseVisualStyleBackColor = true;
            this.BT_AgregarAtributo.Click += new System.EventHandler(this.BT_AgregarAtributo_Click_1);
            // 
            // LB_EntidadAtributo
            // 
            this.LB_EntidadAtributo.AutoSize = true;
            this.LB_EntidadAtributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_EntidadAtributo.Location = new System.Drawing.Point(856, 33);
            this.LB_EntidadAtributo.Name = "LB_EntidadAtributo";
            this.LB_EntidadAtributo.Size = new System.Drawing.Size(68, 20);
            this.LB_EntidadAtributo.TabIndex = 9;
            this.LB_EntidadAtributo.Text = "Entidad ";
            // 
            // ComboB_EntidadAtributo
            // 
            this.ComboB_EntidadAtributo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboB_EntidadAtributo.FormattingEnabled = true;
            this.ComboB_EntidadAtributo.Location = new System.Drawing.Point(828, 55);
            this.ComboB_EntidadAtributo.Name = "ComboB_EntidadAtributo";
            this.ComboB_EntidadAtributo.Size = new System.Drawing.Size(121, 21);
            this.ComboB_EntidadAtributo.TabIndex = 8;
            this.ComboB_EntidadAtributo.SelectedIndexChanged += new System.EventHandler(this.ComboB_EntidadAtributo_SelectedIndexChanged);
            // 
            // LB_TipoIndiceAtributo
            // 
            this.LB_TipoIndiceAtributo.AutoSize = true;
            this.LB_TipoIndiceAtributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TipoIndiceAtributo.Location = new System.Drawing.Point(241, 33);
            this.LB_TipoIndiceAtributo.Name = "LB_TipoIndiceAtributo";
            this.LB_TipoIndiceAtributo.Size = new System.Drawing.Size(86, 20);
            this.LB_TipoIndiceAtributo.TabIndex = 7;
            this.LB_TipoIndiceAtributo.Text = "Tipo Indice";
            // 
            // ComboB_TipoIndiceAtributo
            // 
            this.ComboB_TipoIndiceAtributo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboB_TipoIndiceAtributo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ComboB_TipoIndiceAtributo.FormattingEnabled = true;
            this.ComboB_TipoIndiceAtributo.Items.AddRange(new object[] {
            "0 - Sin tipo de índice",
            "1 - Clave de Búsqueda",
            "2 - Indice Primario",
            "3 - Indice Secundario",
            "4 - Indice Arbol Primario",
            "5 - Indice Arbol Secundario",
            "6 - Llave Primaria (PK)",
            "7 - Llave Secundaria(FK)"});
            this.ComboB_TipoIndiceAtributo.Location = new System.Drawing.Point(222, 57);
            this.ComboB_TipoIndiceAtributo.Name = "ComboB_TipoIndiceAtributo";
            this.ComboB_TipoIndiceAtributo.Size = new System.Drawing.Size(121, 21);
            this.ComboB_TipoIndiceAtributo.TabIndex = 6;
            // 
            // LB_LongitudAtributo
            // 
            this.LB_LongitudAtributo.AutoSize = true;
            this.LB_LongitudAtributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_LongitudAtributo.Location = new System.Drawing.Point(170, 37);
            this.LB_LongitudAtributo.Name = "LB_LongitudAtributo";
            this.LB_LongitudAtributo.Size = new System.Drawing.Size(38, 16);
            this.LB_LongitudAtributo.TabIndex = 5;
            this.LB_LongitudAtributo.Text = "Long";
            // 
            // TextB_LongitudAtributo
            // 
            this.TextB_LongitudAtributo.Location = new System.Drawing.Point(171, 57);
            this.TextB_LongitudAtributo.Name = "TextB_LongitudAtributo";
            this.TextB_LongitudAtributo.Size = new System.Drawing.Size(31, 20);
            this.TextB_LongitudAtributo.TabIndex = 4;
            // 
            // LB_NombreAtributo
            // 
            this.LB_NombreAtributo.AutoSize = true;
            this.LB_NombreAtributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NombreAtributo.Location = new System.Drawing.Point(42, 34);
            this.LB_NombreAtributo.Name = "LB_NombreAtributo";
            this.LB_NombreAtributo.Size = new System.Drawing.Size(65, 20);
            this.LB_NombreAtributo.TabIndex = 3;
            this.LB_NombreAtributo.Text = "Nombre";
            // 
            // ComboB_TipoAtributo
            // 
            this.ComboB_TipoAtributo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboB_TipoAtributo.FormattingEnabled = true;
            this.ComboB_TipoAtributo.Items.AddRange(new object[] {
            "E",
            "C",
            "D"});
            this.ComboB_TipoAtributo.Location = new System.Drawing.Point(124, 56);
            this.ComboB_TipoAtributo.Name = "ComboB_TipoAtributo";
            this.ComboB_TipoAtributo.Size = new System.Drawing.Size(32, 21);
            this.ComboB_TipoAtributo.TabIndex = 2;
            this.ComboB_TipoAtributo.SelectedIndexChanged += new System.EventHandler(this.ComboB_TipoAtributo_SelectedIndexChanged);
            // 
            // TextB_NombreAtributo
            // 
            this.TextB_NombreAtributo.Location = new System.Drawing.Point(18, 57);
            this.TextB_NombreAtributo.Name = "TextB_NombreAtributo";
            this.TextB_NombreAtributo.Size = new System.Drawing.Size(100, 20);
            this.TextB_NombreAtributo.TabIndex = 1;
            // 
            // DGV_Atributos
            // 
            this.DGV_Atributos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Atributos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.NombreAtributo,
            this.TipoIndice,
            this.Longitud,
            this.Dir_Atributo,
            this.Tipo_Indice,
            this.Tipo_Llave,
            this.Dir_Indice,
            this.Dir_Sig_Atrib});
            this.DGV_Atributos.Location = new System.Drawing.Point(7, 113);
            this.DGV_Atributos.Name = "DGV_Atributos";
            this.DGV_Atributos.ReadOnly = true;
            this.DGV_Atributos.Size = new System.Drawing.Size(993, 398);
            this.DGV_Atributos.TabIndex = 0;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            // 
            // NombreAtributo
            // 
            this.NombreAtributo.HeaderText = "Nombre";
            this.NombreAtributo.Name = "NombreAtributo";
            this.NombreAtributo.ReadOnly = true;
            // 
            // TipoIndice
            // 
            this.TipoIndice.HeaderText = "Tipo Dato";
            this.TipoIndice.Name = "TipoIndice";
            this.TipoIndice.ReadOnly = true;
            // 
            // Longitud
            // 
            this.Longitud.HeaderText = "Longitud Dato";
            this.Longitud.Name = "Longitud";
            this.Longitud.ReadOnly = true;
            // 
            // Dir_Atributo
            // 
            this.Dir_Atributo.HeaderText = "Dir_Atributo";
            this.Dir_Atributo.Name = "Dir_Atributo";
            this.Dir_Atributo.ReadOnly = true;
            // 
            // Tipo_Indice
            // 
            this.Tipo_Indice.HeaderText = "Tipo_Indice";
            this.Tipo_Indice.Name = "Tipo_Indice";
            this.Tipo_Indice.ReadOnly = true;
            // 
            // Tipo_Llave
            // 
            this.Tipo_Llave.HeaderText = "Tipo_Llave";
            this.Tipo_Llave.Name = "Tipo_Llave";
            this.Tipo_Llave.ReadOnly = true;
            // 
            // Dir_Indice
            // 
            this.Dir_Indice.HeaderText = "Dir_Indice";
            this.Dir_Indice.Name = "Dir_Indice";
            this.Dir_Indice.ReadOnly = true;
            // 
            // Dir_Sig_Atrib
            // 
            this.Dir_Sig_Atrib.HeaderText = "Dir_Sig_Atrib";
            this.Dir_Sig_Atrib.Name = "Dir_Sig_Atrib";
            this.Dir_Sig_Atrib.ReadOnly = true;
            // 
            // Pestaña_Registros
            // 
            this.Pestaña_Registros.Controls.Add(this.BT_LimpiarDGVAtributosRegistro);
            this.Pestaña_Registros.Controls.Add(this.BT_EliminarRegistro);
            this.Pestaña_Registros.Controls.Add(this.BT_ModificarRegistro);
            this.Pestaña_Registros.Controls.Add(this.BT_AgregarRegistro);
            this.Pestaña_Registros.Controls.Add(this.DGV_AtributosRegistro);
            this.Pestaña_Registros.Controls.Add(this.DGV_Registros);
            this.Pestaña_Registros.Controls.Add(this.label2);
            this.Pestaña_Registros.Controls.Add(this.ComboB_EntidadRegistros);
            this.Pestaña_Registros.Location = new System.Drawing.Point(4, 22);
            this.Pestaña_Registros.Name = "Pestaña_Registros";
            this.Pestaña_Registros.Size = new System.Drawing.Size(1006, 533);
            this.Pestaña_Registros.TabIndex = 2;
            this.Pestaña_Registros.Text = "Registros";
            this.Pestaña_Registros.UseVisualStyleBackColor = true;
            // 
            // BT_LimpiarDGVAtributosRegistro
            // 
            this.BT_LimpiarDGVAtributosRegistro.Location = new System.Drawing.Point(17, 106);
            this.BT_LimpiarDGVAtributosRegistro.Name = "BT_LimpiarDGVAtributosRegistro";
            this.BT_LimpiarDGVAtributosRegistro.Size = new System.Drawing.Size(75, 23);
            this.BT_LimpiarDGVAtributosRegistro.TabIndex = 7;
            this.BT_LimpiarDGVAtributosRegistro.Text = "Limpiar";
            this.BT_LimpiarDGVAtributosRegistro.UseVisualStyleBackColor = true;
            this.BT_LimpiarDGVAtributosRegistro.Click += new System.EventHandler(this.BT_LimpiarDGVAtributosRegistro_Click);
            // 
            // BT_EliminarRegistro
            // 
            this.BT_EliminarRegistro.Location = new System.Drawing.Point(315, 135);
            this.BT_EliminarRegistro.Name = "BT_EliminarRegistro";
            this.BT_EliminarRegistro.Size = new System.Drawing.Size(125, 23);
            this.BT_EliminarRegistro.TabIndex = 6;
            this.BT_EliminarRegistro.Text = "Eliminar Registro";
            this.BT_EliminarRegistro.UseVisualStyleBackColor = true;
            this.BT_EliminarRegistro.Click += new System.EventHandler(this.BT_EliminarRegistro_Click);
            // 
            // BT_ModificarRegistro
            // 
            this.BT_ModificarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BT_ModificarRegistro.Location = new System.Drawing.Point(167, 135);
            this.BT_ModificarRegistro.Name = "BT_ModificarRegistro";
            this.BT_ModificarRegistro.Size = new System.Drawing.Size(129, 23);
            this.BT_ModificarRegistro.TabIndex = 5;
            this.BT_ModificarRegistro.Text = "Modificar Registro";
            this.BT_ModificarRegistro.UseVisualStyleBackColor = true;
            this.BT_ModificarRegistro.Click += new System.EventHandler(this.BT_ModificarRegistro_Click);
            // 
            // BT_AgregarRegistro
            // 
            this.BT_AgregarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BT_AgregarRegistro.Location = new System.Drawing.Point(17, 135);
            this.BT_AgregarRegistro.Name = "BT_AgregarRegistro";
            this.BT_AgregarRegistro.Size = new System.Drawing.Size(123, 23);
            this.BT_AgregarRegistro.TabIndex = 4;
            this.BT_AgregarRegistro.Text = "Agregar Registro";
            this.BT_AgregarRegistro.UseVisualStyleBackColor = true;
            this.BT_AgregarRegistro.Click += new System.EventHandler(this.BT_AgregarRegistro_Click);
            // 
            // DGV_AtributosRegistro
            // 
            this.DGV_AtributosRegistro.AllowUserToAddRows = false;
            this.DGV_AtributosRegistro.AllowUserToDeleteRows = false;
            this.DGV_AtributosRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_AtributosRegistro.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_AtributosRegistro.Location = new System.Drawing.Point(17, 33);
            this.DGV_AtributosRegistro.MultiSelect = false;
            this.DGV_AtributosRegistro.Name = "DGV_AtributosRegistro";
            this.DGV_AtributosRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV_AtributosRegistro.ShowCellErrors = false;
            this.DGV_AtributosRegistro.Size = new System.Drawing.Size(816, 67);
            this.DGV_AtributosRegistro.TabIndex = 3;
            this.DGV_AtributosRegistro.SelectionChanged += new System.EventHandler(this.DGV_AtributosRegistro_SelectionChanged);
            // 
            // DGV_Registros
            // 
            this.DGV_Registros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Registros.Location = new System.Drawing.Point(17, 179);
            this.DGV_Registros.Name = "DGV_Registros";
            this.DGV_Registros.Size = new System.Drawing.Size(974, 339);
            this.DGV_Registros.TabIndex = 2;
            this.DGV_Registros.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Registros_CellMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(885, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entidad";
            // 
            // ComboB_EntidadRegistros
            // 
            this.ComboB_EntidadRegistros.FormattingEnabled = true;
            this.ComboB_EntidadRegistros.Location = new System.Drawing.Point(859, 57);
            this.ComboB_EntidadRegistros.Name = "ComboB_EntidadRegistros";
            this.ComboB_EntidadRegistros.Size = new System.Drawing.Size(121, 21);
            this.ComboB_EntidadRegistros.TabIndex = 0;
            this.ComboB_EntidadRegistros.SelectedIndexChanged += new System.EventHandler(this.ComboB_EntidadRegistros_SelectedIndexChanged);
            // 
            // Pestaña_Indices
            // 
            this.Pestaña_Indices.Controls.Add(this.DGV_CajonIndiceSecundario);
            this.Pestaña_Indices.Controls.Add(this.LB_EntidadIndice);
            this.Pestaña_Indices.Controls.Add(this.LB_IndiceSecundario);
            this.Pestaña_Indices.Controls.Add(this.LB_IndicePrimario);
            this.Pestaña_Indices.Controls.Add(this.DGV_BloquePrincipalIndiceSecundario);
            this.Pestaña_Indices.Controls.Add(this.DGV_IndicePrimario);
            this.Pestaña_Indices.Location = new System.Drawing.Point(4, 22);
            this.Pestaña_Indices.Name = "Pestaña_Indices";
            this.Pestaña_Indices.Size = new System.Drawing.Size(1006, 533);
            this.Pestaña_Indices.TabIndex = 3;
            this.Pestaña_Indices.Text = "Indices";
            this.Pestaña_Indices.UseVisualStyleBackColor = true;
            // 
            // DGV_CajonIndiceSecundario
            // 
            this.DGV_CajonIndiceSecundario.AllowUserToAddRows = false;
            this.DGV_CajonIndiceSecundario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CajonIndiceSecundario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DireccionCSecundario});
            this.DGV_CajonIndiceSecundario.Location = new System.Drawing.Point(831, 101);
            this.DGV_CajonIndiceSecundario.Name = "DGV_CajonIndiceSecundario";
            this.DGV_CajonIndiceSecundario.Size = new System.Drawing.Size(143, 388);
            this.DGV_CajonIndiceSecundario.TabIndex = 6;
            // 
            // DireccionCSecundario
            // 
            this.DireccionCSecundario.HeaderText = "Dirección";
            this.DireccionCSecundario.Name = "DireccionCSecundario";
            // 
            // LB_EntidadIndice
            // 
            this.LB_EntidadIndice.AutoSize = true;
            this.LB_EntidadIndice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_EntidadIndice.Location = new System.Drawing.Point(465, 12);
            this.LB_EntidadIndice.Name = "LB_EntidadIndice";
            this.LB_EntidadIndice.Size = new System.Drawing.Size(60, 24);
            this.LB_EntidadIndice.TabIndex = 5;
            this.LB_EntidadIndice.Text = "label3";
            // 
            // LB_IndiceSecundario
            // 
            this.LB_IndiceSecundario.AllowDrop = true;
            this.LB_IndiceSecundario.AutoSize = true;
            this.LB_IndiceSecundario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_IndiceSecundario.Location = new System.Drawing.Point(616, 74);
            this.LB_IndiceSecundario.Name = "LB_IndiceSecundario";
            this.LB_IndiceSecundario.Size = new System.Drawing.Size(163, 24);
            this.LB_IndiceSecundario.TabIndex = 3;
            this.LB_IndiceSecundario.Text = "Indice Secundario";
            // 
            // LB_IndicePrimario
            // 
            this.LB_IndicePrimario.AllowDrop = true;
            this.LB_IndicePrimario.AutoSize = true;
            this.LB_IndicePrimario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_IndicePrimario.Location = new System.Drawing.Point(87, 74);
            this.LB_IndicePrimario.Name = "LB_IndicePrimario";
            this.LB_IndicePrimario.Size = new System.Drawing.Size(135, 24);
            this.LB_IndicePrimario.TabIndex = 2;
            this.LB_IndicePrimario.Text = "Indice Primario";
            // 
            // DGV_BloquePrincipalIndiceSecundario
            // 
            this.DGV_BloquePrincipalIndiceSecundario.AllowUserToAddRows = false;
            this.DGV_BloquePrincipalIndiceSecundario.AllowUserToDeleteRows = false;
            this.DGV_BloquePrincipalIndiceSecundario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_BloquePrincipalIndiceSecundario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LlaveSecundaria,
            this.DireccionCajonSecundario});
            this.DGV_BloquePrincipalIndiceSecundario.Location = new System.Drawing.Point(565, 101);
            this.DGV_BloquePrincipalIndiceSecundario.Name = "DGV_BloquePrincipalIndiceSecundario";
            this.DGV_BloquePrincipalIndiceSecundario.ReadOnly = true;
            this.DGV_BloquePrincipalIndiceSecundario.Size = new System.Drawing.Size(244, 388);
            this.DGV_BloquePrincipalIndiceSecundario.TabIndex = 1;
            this.DGV_BloquePrincipalIndiceSecundario.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_BloquePrincipalIndiceSecundario_CellMouseDoubleClick);
            // 
            // LlaveSecundaria
            // 
            this.LlaveSecundaria.HeaderText = "Llave";
            this.LlaveSecundaria.Name = "LlaveSecundaria";
            this.LlaveSecundaria.ReadOnly = true;
            // 
            // DireccionCajonSecundario
            // 
            this.DireccionCajonSecundario.HeaderText = "Direccion";
            this.DireccionCajonSecundario.Name = "DireccionCajonSecundario";
            this.DireccionCajonSecundario.ReadOnly = true;
            // 
            // DGV_IndicePrimario
            // 
            this.DGV_IndicePrimario.AllowUserToAddRows = false;
            this.DGV_IndicePrimario.AllowUserToDeleteRows = false;
            this.DGV_IndicePrimario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_IndicePrimario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Llave,
            this.Dirección});
            this.DGV_IndicePrimario.Location = new System.Drawing.Point(35, 101);
            this.DGV_IndicePrimario.Name = "DGV_IndicePrimario";
            this.DGV_IndicePrimario.ReadOnly = true;
            this.DGV_IndicePrimario.Size = new System.Drawing.Size(243, 388);
            this.DGV_IndicePrimario.TabIndex = 0;
            // 
            // Llave
            // 
            this.Llave.HeaderText = "Llave";
            this.Llave.Name = "Llave";
            this.Llave.ReadOnly = true;
            // 
            // Dirección
            // 
            this.Dirección.HeaderText = "Dirección";
            this.Dirección.Name = "Dirección";
            this.Dirección.ReadOnly = true;
            // 
            // Pestaña_ArbolPrimario
            // 
            this.Pestaña_ArbolPrimario.Controls.Add(this.DGV_ArbolPrimarioBloquePrincipal);
            this.Pestaña_ArbolPrimario.Location = new System.Drawing.Point(4, 22);
            this.Pestaña_ArbolPrimario.Name = "Pestaña_ArbolPrimario";
            this.Pestaña_ArbolPrimario.Size = new System.Drawing.Size(1006, 533);
            this.Pestaña_ArbolPrimario.TabIndex = 4;
            this.Pestaña_ArbolPrimario.Text = "Arbol Primario";
            this.Pestaña_ArbolPrimario.UseVisualStyleBackColor = true;
            // 
            // DGV_ArbolPrimarioBloquePrincipal
            // 
            this.DGV_ArbolPrimarioBloquePrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ArbolPrimarioBloquePrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoNArbolP,
            this.DirN_ArbolP,
            this.Ap1ArbolP,
            this.K1ArbolP,
            this.Ap2ArbolP,
            this.K2ArbolP,
            this.Ap3ArbolP,
            this.K3ArbolP,
            this.Ap4ArbolP,
            this.K4ArbolP,
            this.Sig});
            this.DGV_ArbolPrimarioBloquePrincipal.Location = new System.Drawing.Point(208, 107);
            this.DGV_ArbolPrimarioBloquePrincipal.Name = "DGV_ArbolPrimarioBloquePrincipal";
            this.DGV_ArbolPrimarioBloquePrincipal.Size = new System.Drawing.Size(619, 392);
            this.DGV_ArbolPrimarioBloquePrincipal.TabIndex = 0;
            // 
            // TipoNArbolP
            // 
            this.TipoNArbolP.HeaderText = "Tipo";
            this.TipoNArbolP.Name = "TipoNArbolP";
            this.TipoNArbolP.Width = 50;
            // 
            // DirN_ArbolP
            // 
            this.DirN_ArbolP.HeaderText = "Dir_Nodo";
            this.DirN_ArbolP.Name = "DirN_ArbolP";
            this.DirN_ArbolP.Width = 75;
            // 
            // Ap1ArbolP
            // 
            this.Ap1ArbolP.HeaderText = "Ap1";
            this.Ap1ArbolP.Name = "Ap1ArbolP";
            this.Ap1ArbolP.Width = 50;
            // 
            // K1ArbolP
            // 
            this.K1ArbolP.HeaderText = "K1";
            this.K1ArbolP.Name = "K1ArbolP";
            this.K1ArbolP.Width = 50;
            // 
            // Ap2ArbolP
            // 
            this.Ap2ArbolP.HeaderText = "Ap2";
            this.Ap2ArbolP.Name = "Ap2ArbolP";
            this.Ap2ArbolP.Width = 50;
            // 
            // K2ArbolP
            // 
            this.K2ArbolP.HeaderText = "K2";
            this.K2ArbolP.Name = "K2ArbolP";
            this.K2ArbolP.Width = 50;
            // 
            // Ap3ArbolP
            // 
            this.Ap3ArbolP.HeaderText = "Ap3";
            this.Ap3ArbolP.Name = "Ap3ArbolP";
            this.Ap3ArbolP.Width = 50;
            // 
            // K3ArbolP
            // 
            this.K3ArbolP.HeaderText = "K3";
            this.K3ArbolP.Name = "K3ArbolP";
            this.K3ArbolP.Width = 50;
            // 
            // Ap4ArbolP
            // 
            this.Ap4ArbolP.HeaderText = "Ap4";
            this.Ap4ArbolP.Name = "Ap4ArbolP";
            this.Ap4ArbolP.Width = 50;
            // 
            // K4ArbolP
            // 
            this.K4ArbolP.HeaderText = "K4";
            this.K4ArbolP.Name = "K4ArbolP";
            this.K4ArbolP.Width = 50;
            // 
            // Sig
            // 
            this.Sig.HeaderText = "Ap5";
            this.Sig.Name = "Sig";
            this.Sig.Width = 50;
            // 
            // Pestaña_ArbolSecundario
            // 
            this.Pestaña_ArbolSecundario.Controls.Add(this.DGV_ArbolSSecundario);
            this.Pestaña_ArbolSecundario.Controls.Add(this.DGV_ArbolSecundario);
            this.Pestaña_ArbolSecundario.Location = new System.Drawing.Point(4, 22);
            this.Pestaña_ArbolSecundario.Name = "Pestaña_ArbolSecundario";
            this.Pestaña_ArbolSecundario.Size = new System.Drawing.Size(1006, 533);
            this.Pestaña_ArbolSecundario.TabIndex = 5;
            this.Pestaña_ArbolSecundario.Text = "Arbol Secundario";
            this.Pestaña_ArbolSecundario.UseVisualStyleBackColor = true;
            // 
            // DGV_ArbolSSecundario
            // 
            this.DGV_ArbolSSecundario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ArbolSSecundario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dir});
            this.DGV_ArbolSSecundario.Location = new System.Drawing.Point(744, 126);
            this.DGV_ArbolSSecundario.Name = "DGV_ArbolSSecundario";
            this.DGV_ArbolSSecundario.Size = new System.Drawing.Size(140, 392);
            this.DGV_ArbolSSecundario.TabIndex = 3;
            // 
            // Dir
            // 
            this.Dir.HeaderText = "Direccion";
            this.Dir.Name = "Dir";
            // 
            // DGV_ArbolSecundario
            // 
            this.DGV_ArbolSecundario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ArbolSecundario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.DGV_ArbolSecundario.Location = new System.Drawing.Point(45, 126);
            this.DGV_ArbolSecundario.Name = "DGV_ArbolSecundario";
            this.DGV_ArbolSecundario.Size = new System.Drawing.Size(618, 392);
            this.DGV_ArbolSecundario.TabIndex = 2;
            this.DGV_ArbolSecundario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_ArbolSecundario_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Dir_Nodo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Ap1";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "K1";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Ap2";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "K2";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Ap3";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "K3";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Ap4";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 50;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "K4";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 50;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Ap5";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 50;
            // 
            // Pestaña_Relaciones
            // 
            this.Pestaña_Relaciones.Controls.Add(this.LB_EntidadRelaciones);
            this.Pestaña_Relaciones.Controls.Add(this.ComboB_EntidadRelaciones);
            this.Pestaña_Relaciones.Controls.Add(this.DGV_Relaciones);
            this.Pestaña_Relaciones.Location = new System.Drawing.Point(4, 22);
            this.Pestaña_Relaciones.Name = "Pestaña_Relaciones";
            this.Pestaña_Relaciones.Size = new System.Drawing.Size(1006, 533);
            this.Pestaña_Relaciones.TabIndex = 6;
            this.Pestaña_Relaciones.Text = "Relaciones";
            this.Pestaña_Relaciones.UseVisualStyleBackColor = true;
            // 
            // LB_EntidadRelaciones
            // 
            this.LB_EntidadRelaciones.AutoSize = true;
            this.LB_EntidadRelaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_EntidadRelaciones.Location = new System.Drawing.Point(742, 42);
            this.LB_EntidadRelaciones.Name = "LB_EntidadRelaciones";
            this.LB_EntidadRelaciones.Size = new System.Drawing.Size(80, 20);
            this.LB_EntidadRelaciones.TabIndex = 2;
            this.LB_EntidadRelaciones.Text = "ENTIDAD";
            // 
            // ComboB_EntidadRelaciones
            // 
            this.ComboB_EntidadRelaciones.FormattingEnabled = true;
            this.ComboB_EntidadRelaciones.Location = new System.Drawing.Point(721, 75);
            this.ComboB_EntidadRelaciones.Name = "ComboB_EntidadRelaciones";
            this.ComboB_EntidadRelaciones.Size = new System.Drawing.Size(121, 21);
            this.ComboB_EntidadRelaciones.TabIndex = 1;
            this.ComboB_EntidadRelaciones.SelectedIndexChanged += new System.EventHandler(this.ComboB_EntidadRelaciones_SelectedIndexChanged);
            // 
            // DGV_Relaciones
            // 
            this.DGV_Relaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Relaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaTablaHijo,
            this.ColumnaAtributoHijo,
            this.ColumnaTablaPadre,
            this.ColumnaAtributoTablaPadre});
            this.DGV_Relaciones.Location = new System.Drawing.Point(136, 42);
            this.DGV_Relaciones.Name = "DGV_Relaciones";
            this.DGV_Relaciones.Size = new System.Drawing.Size(442, 444);
            this.DGV_Relaciones.TabIndex = 0;
            // 
            // ColumnaTablaHijo
            // 
            this.ColumnaTablaHijo.HeaderText = "Tabla Hijo";
            this.ColumnaTablaHijo.Name = "ColumnaTablaHijo";
            this.ColumnaTablaHijo.ReadOnly = true;
            // 
            // ColumnaAtributoHijo
            // 
            this.ColumnaAtributoHijo.HeaderText = "Nombre Atributo";
            this.ColumnaAtributoHijo.Name = "ColumnaAtributoHijo";
            this.ColumnaAtributoHijo.ReadOnly = true;
            // 
            // ColumnaTablaPadre
            // 
            this.ColumnaTablaPadre.HeaderText = "Tabla Padre";
            this.ColumnaTablaPadre.Name = "ColumnaTablaPadre";
            this.ColumnaTablaPadre.ReadOnly = true;
            // 
            // ColumnaAtributoTablaPadre
            // 
            this.ColumnaAtributoTablaPadre.HeaderText = "Atributo Tabla Padre";
            this.ColumnaAtributoTablaPadre.Name = "ColumnaAtributoTablaPadre";
            this.ColumnaAtributoTablaPadre.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(83, 26);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.aToolStripMenuItem.Text = "A";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1033, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirArchivoToolStripMenuItem,
            this.NuevoArchivoToolStripMenuItem,
            this.cerrarArchivoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirArchivoToolStripMenuItem
            // 
            this.abrirArchivoToolStripMenuItem.Name = "abrirArchivoToolStripMenuItem";
            this.abrirArchivoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.abrirArchivoToolStripMenuItem.Text = "Abrir Archivo";
            this.abrirArchivoToolStripMenuItem.Click += new System.EventHandler(this.AbrirArchivoToolStripMenuItem_Click);
            // 
            // NuevoArchivoToolStripMenuItem
            // 
            this.NuevoArchivoToolStripMenuItem.Name = "NuevoArchivoToolStripMenuItem";
            this.NuevoArchivoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.NuevoArchivoToolStripMenuItem.Text = "Nuevo Archivo";
            this.NuevoArchivoToolStripMenuItem.Click += new System.EventHandler(this.NuevoArchivoToolStripMenuItem_Click);
            // 
            // cerrarArchivoToolStripMenuItem
            // 
            this.cerrarArchivoToolStripMenuItem.Name = "cerrarArchivoToolStripMenuItem";
            this.cerrarArchivoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.cerrarArchivoToolStripMenuItem.Text = "Cerrar Archivo";
            this.cerrarArchivoToolStripMenuItem.Click += new System.EventHandler(this.CerrarArchivoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 598);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Pestañas);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Diccionario de Datos";
            this.Pestañas.ResumeLayout(false);
            this.Pestaña_Entidades.ResumeLayout(false);
            this.Pestaña_Entidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Entidades)).EndInit();
            this.Pestaña_Atributos.ResumeLayout(false);
            this.Pestaña_Atributos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Atributos)).EndInit();
            this.Pestaña_Registros.ResumeLayout(false);
            this.Pestaña_Registros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AtributosRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Registros)).EndInit();
            this.Pestaña_Indices.ResumeLayout(false);
            this.Pestaña_Indices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CajonIndiceSecundario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BloquePrincipalIndiceSecundario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_IndicePrimario)).EndInit();
            this.Pestaña_ArbolPrimario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ArbolPrimarioBloquePrincipal)).EndInit();
            this.Pestaña_ArbolSecundario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ArbolSSecundario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ArbolSecundario)).EndInit();
            this.Pestaña_Relaciones.ResumeLayout(false);
            this.Pestaña_Relaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Relaciones)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Pestañas;
        private System.Windows.Forms.TabPage Pestaña_Entidades;
        private System.Windows.Forms.TabPage Pestaña_Atributos;
        private System.Windows.Forms.ComboBox ComboB_AccionesEntidad;
        private System.Windows.Forms.DataGridView DGV_Entidades;
        private System.Windows.Forms.TextBox TextB_NombreEntidad;
        private System.Windows.Forms.Label LB_NombreEntidad;
        private System.Windows.Forms.TextBox TextB_NuevoNombEnt;
        private System.Windows.Forms.TextBox TextB_NombreActualEnt;
        private System.Windows.Forms.Label LB_Mod_NuevoNombre;
        private System.Windows.Forms.Label LB_Mod_NombreActual;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ComboB_TipoAtributo;
        private System.Windows.Forms.TextBox TextB_NombreAtributo;
        private System.Windows.Forms.DataGridView DGV_Atributos;
        private System.Windows.Forms.Label LB_TipoIndiceAtributo;
        private System.Windows.Forms.ComboBox ComboB_TipoIndiceAtributo;
        private System.Windows.Forms.Label LB_LongitudAtributo;
        private System.Windows.Forms.TextBox TextB_LongitudAtributo;
        private System.Windows.Forms.Label LB_NombreAtributo;
        private System.Windows.Forms.Button BT_AgregarAtributo;
        private System.Windows.Forms.Label LB_EntidadAtributo;
        private System.Windows.Forms.ComboBox ComboB_EntidadAtributo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NuevoArchivoToolStripMenuItem;
        private System.Windows.Forms.Label LB_Cabecera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEntidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion_Entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir_Atrib;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir_Dato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir_Siguiente_Entidad;
        private System.Windows.Forms.ComboBox ComboB_AccionesAtributos;
        private System.Windows.Forms.Button BT_BusquedaAtributo;
        private System.Windows.Forms.ToolStripMenuItem cerrarArchivoToolStripMenuItem;
        private System.Windows.Forms.TabPage Pestaña_Registros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboB_EntidadRegistros;
        private System.Windows.Forms.DataGridView DGV_Registros;
        private System.Windows.Forms.DataGridView DGV_AtributosRegistro;
        private System.Windows.Forms.Button BT_EliminarRegistro;
        private System.Windows.Forms.Button BT_ModificarRegistro;
        private System.Windows.Forms.Button BT_AgregarRegistro;
        private System.Windows.Forms.TabPage Pestaña_Indices;
        private System.Windows.Forms.DataGridView DGV_IndicePrimario;
        private System.Windows.Forms.Label LB_IndiceSecundario;
        private System.Windows.Forms.Label LB_IndicePrimario;
        private System.Windows.Forms.DataGridView DGV_BloquePrincipalIndiceSecundario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Llave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dirección;
        private System.Windows.Forms.Button BT_LimpiarDGVAtributosRegistro;
        private System.Windows.Forms.Label LB_EntidadIndice;
        private System.Windows.Forms.DataGridViewTextBoxColumn LlaveSecundaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionCajonSecundario;
        private System.Windows.Forms.DataGridView DGV_CajonIndiceSecundario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionCSecundario;
        private System.Windows.Forms.TabPage Pestaña_ArbolPrimario;
        private System.Windows.Forms.TabPage Pestaña_ArbolSecundario;
        private System.Windows.Forms.DataGridView DGV_ArbolPrimarioBloquePrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoNArbolP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirN_ArbolP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ap1ArbolP;
        private System.Windows.Forms.DataGridViewTextBoxColumn K1ArbolP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ap2ArbolP;
        private System.Windows.Forms.DataGridViewTextBoxColumn K2ArbolP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ap3ArbolP;
        private System.Windows.Forms.DataGridViewTextBoxColumn K3ArbolP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ap4ArbolP;
        private System.Windows.Forms.DataGridViewTextBoxColumn K4ArbolP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sig;
        private System.Windows.Forms.DataGridView DGV_ArbolSSecundario;
        private System.Windows.Forms.DataGridView DGV_ArbolSecundario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir;
        private System.Windows.Forms.ComboBox CB_TipoLlave;
        private System.Windows.Forms.Label LB_TipoLlave;
        private System.Windows.Forms.Label LB_AccionAtributo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAtributo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoIndice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir_Atributo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Llave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir_Indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir_Sig_Atrib;
        private System.Windows.Forms.TabPage Pestaña_Relaciones;
        private System.Windows.Forms.Label LB_EntidadRelaciones;
        private System.Windows.Forms.ComboBox ComboB_EntidadRelaciones;
        private System.Windows.Forms.DataGridView DGV_Relaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaTablaHijo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaAtributoHijo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaTablaPadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaAtributoTablaPadre;
    }
}

