namespace CleanAddress.Dadata.Client.Dto
{
    public class CleanAddressDto
    {
        public string? Source { get; set; }
        public string? Result { get; set; }
        public string? Postal_code { get; set; }
        public string? Country { get; set; }
        public string? Country_iso_code { get; set; }
        public string? Federal_district { get; set; }
        public string? Region_fias_id { get; set; }
        public string? Region_kladr_id { get; set; }
        public string? Region_iso_code { get; set; }
        public string? Region_with_type { get; set; }
        public string? Region_type { get; set; }
        public string? Region_type_full { get; set; }
        public string? Region { get; set; }
        public string? Area_fias_id { get; set; }
        public string? Area_kladr_id { get; set; }
        public string? Area_with_type { get; set; }
        public string? Area_type { get; set; }
        public string? Area_type_full { get; set; }
        public string? Area { get; set; }
        public string? City_fias_id { get; set; }
        public string? City_kladr_id { get; set; }
        public string? City_with_type { get; set; }
        public string? City_type { get; set; }
        public string? City_type_full { get; set; }
        public string? City { get; set; }
        public string? City_area { get; set; }
        public string? City_district_fias_id { get; set; }
        public string? City_district_kladr_id { get; set; }
        public string? City_district_with_type { get; set; }
        public string? City_district_type { get; set; }
        public string? City_district_type_full { get; set; }
        public string? City_district { get; set; }
        public string? Settlement_fias_id { get; set; }
        public string? Settlement_kladr_id { get; set; }
        public string? Settlement_with_type { get; set; }
        public string? Settlement_type { get; set; }
        public string? Settlement_type_full { get; set; }
        public string? Settlement { get; set; }
        public string? Street_fias_id { get; set; }
        public string? Street_kladr_id { get; set; }
        public string? Street_with_type { get; set; }
        public string? Street_type { get; set; }
        public string? Street_type_full { get; set; }
        public string? Street { get; set; }
        public string? House_fias_id { get; set; }
        public string? House_kladr_id { get; set; }
        public string? House_cadnum { get; set; }
        public string? House_type { get; set; }
        public string? House_type_full { get; set; }
        public string? House { get; set; }
        public string? Block_type { get; set; }
        public string? Block_type_full { get; set; }
        public string? Block { get; set; }
        public string? Entrance { get; set; }
        public string? Floor { get; set; }
        public string? Flat_fias_id { get; set; }
        public string? Flat_cadnum { get; set; }
        public string? Flat_type { get; set; }
        public string? Flat_type_full { get; set; }
        public string? Flat { get; set; }
        public string? Flat_area { get; set; }
        public string? Square_meter_price { get; set; }
        public string? Flat_price { get; set; }
        public string? Postal_box { get; set; }
        public string? Fias_id { get; set; }
        public string? Fias_code { get; set; }
        public string? Fias_level { get; set; }
        public string? Fias_actuality_state { get; set; }
        public string? Kladr_id { get; set; }
        public string? Capital_marker { get; set; }
        public string? Okato { get; set; }
        public string? Oktmo { get; set; }
        public string? Tax_office { get; set; }
        public string? Tax_office_legal { get; set; }
        public string? Timezone { get; set; }
        public string? Geo_lat { get; set; }
        public string? Geo_lon { get; set; }
        public string? Beltway_hit { get; set; }
        public string? Beltway_distance { get; set; }
        public int Qc_geo { get; set; }
        public int Qc_complete { get; set; }
        public int Qc_house { get; set; }
        public int Qc { get; set; }
        public string? Unparsed_parts { get; set; }
        public List<Metro> Metro { get; set; }

    }
    public class Metro
    {
        public double Distance { get; set; }
        public string? Line { get; set; }
        public string? Name { get; set; }
    }
}
