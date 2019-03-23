/*
* AntiDupl.NET Program (http://ermig1979.github.io/AntiDupl).
*
* Copyright (c) 2002-2018 Yermalayeu Ihar, 2013-2018 Borisov Dmitry.
*
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
*
* The above copyright notice and this permission notice shall be included in
* all copies or substantial portions of the Software.
*
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
* SOFTWARE.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace AntiDupl.NET
{
    static public class StringsDefaultRussian
    {
        static public void CopyTo(Strings s)
        {
            s.Name = "Russian";
            s.OriginalLanguageName = "�������";

            s.OkButton_Text = "OK";
            s.CancelButton_Text = "������";
            s.StopButton_Text = "����";
            s.SetDefaultButton_Text = "�� ���������";

            s.ErrorMessage_FileAlreadyExists = "���������� ������������� ����, ��� ��� ���� � ����� ������ ��� ����������!";

            s.WarningMessage_ChangeFileExtension = "�� ������������� ������ �������� ���������� �����?";

            s.AboutProgramPanel_CopyrightLabel0_Text = "Copyright (c) 2002-2018 �������� �����,";
            s.AboutProgramPanel_CopyrightLabel1_Text = "2013-2018 ������� �������.";
            s.AboutProgramPanel_ComponentLabel_Text = "���������";
            s.AboutProgramPanel_VersionLabel_Text = "������";

            s.AboutProgramForm_Text = "� ���������...";

            s.StartFinishForm_LoadImages_Text = "�������� ����� ��������";
            s.StartFinishForm_LoadMistakes_Text = "�������� ����� ������";
            s.StartFinishForm_LoadResults_Text = "�������� ����� �����������";
            s.StartFinishForm_SaveImages_Text = "���������� ����� ��������";
            s.StartFinishForm_SaveMistakes_Text = "���������� ����� ������";
            s.StartFinishForm_SaveResults_Text = "���������� ����� �����������";
            s.StartFinishForm_ClearTemporary_Text = "�������� ��������� ������";

            s.CoreOptionsForm_Text = "�����";

            s.CoreOptionsForm_SearchTabPage_Text = "�����";
            s.CoreOptionsForm_SearchFileTypeGroupBox_Text = "������ ����:";
            s.CoreOptionsForm_BmpCheckBox_Text = "BMP";
            s.CoreOptionsForm_GifCheckBox_Text = "GIF";
            s.CoreOptionsForm_JpegCheckBox_Text = "JPEG";
            s.CoreOptionsForm_PngCheckBox_Text = "PNG";
            s.CoreOptionsForm_TiffCheckBox_Text = "TIFF";
            s.CoreOptionsForm_EmfCheckBox_Text = "EMF";
            s.CoreOptionsForm_WmfCheckBox_Text = "WMF";
            s.CoreOptionsForm_ExifCheckBox_Text = "EXIF";
            s.CoreOptionsForm_IconCheckBox_Text = "ICON";
            s.CoreOptionsForm_Jp2CheckBox_Text = "JP2";
            s.CoreOptionsForm_PsdCheckBox_Text = "PSD";
            s.CoreOptionsForm_DdsCheckBox_Text = "DDS";
            s.CoreOptionsForm_TgaCheckBox_Text = "TGA";
            s.CoreOptionsForm_SearchSystemCheckBox_Text = "������ ��������� ��������/�����";
            s.CoreOptionsForm_SearchHiddenCheckBox_Text = "������ ������� ��������/�����";

            s.CoreOptionsForm_CompareTabPage_Text = "���������";
            s.CoreOptionsForm_CheckOnEqualityCheckBox_Text = "������ ����������� ��������";
            s.CoreOptionsForm_TransformedImageCheckBox_Text = "������ ���������� � ���������� ���������";
            s.CoreOptionsForm_SizeControlCheckBox_Text = "��������� ������ ��������";
            s.CoreOptionsForm_TypeControlCheckBox_Text = "��������� ��� ��������";
            s.CoreOptionsForm_RatioControlCheckBox_Text = "��������� ����������� ������/������ ��������";
            s.CoreOptionsForm_AlgorithmComparingLabeledComboBox_Text = "�������� ��������� �����������";
            s.CoreOptionsForm_AlgorithmComparingLabeledComboBox_SquaredSum = "������������������ ��������";
            s.CoreOptionsForm_ThresholdDifferenceLabeledComboBox_Text = "��������� ��������";
            s.CoreOptionsForm_MinimalImageSizeLabeledIntegerEdit_Text = "����������� ������/������ ��������";
            s.CoreOptionsForm_MaximalImageSizeLabeledIntegerEdit_Text = "������������ ������/������ ��������";
            s.CoreOptionsForm_CompareInsideOneSearchPathCheckBox_Text = "���������� �������� �� ������ ���� ������ ���� � ������";
            s.CoreOptionsForm_CompareInsideOneFolderCheckBox_Text = "���������� �������� ������ ������ ��������";

            s.CoreOptionsForm_DefectTabPage_Text = "�������";
            s.CoreOptionsForm_CheckOnDefectCheckBox_Text = "��������� �� �������";
            s.CoreOptionsForm_CheckOnBlockinessCheckBox_Text = "��������� �� ���������";
            s.CoreOptionsForm_BlockinessThresholdLabeledComboBox_Text = "����� ���������";
            s.CoreOptionsForm_CheckOnBlockinessOnlyNotJpegCheckBox_Text = "��������� �� ��������� ������ ��� �� Jpeg";
            s.CoreOptionsForm_CheckOnBlurringCheckBox_Text = "��������� �� ����������";
            s.CoreOptionsForm_BlurringThresholdLabeledComboBox_Text = "����� ����������";

            s.CoreOptionsForm_AdvancedTabPage_Text = "��������������";
            s.CoreOptionsForm_DeleteToRecycleBinCheckBox_Text = "������� � �������";
            s.CoreOptionsForm_MistakeDataBaseCheckBox_Text = "���������� ������ ������������";
            s.CoreOptionsForm_RatioResolutionLabeledComboBox_Text = "�������� ����������� ������/������ ��������";
            s.CoreOptionsForm_CompareThreadCountLabeledComboBox_Text = "���������� ������� ���������";
            s.CoreOptionsForm_CompareThreadCountLabeledComboBox_Description_0 = "����";
            s.CoreOptionsForm_CollectThreadCountLabeledComboBox_Text = "���������� ������� ��������";
            s.CoreOptionsForm_CollectThreadCountLabeledComboBox_Description_0 = "����";
            s.CoreOptionsForm_ReducedImageSizeLabeledComboBox_Text = "��������������� ������ ��������";
            s.CoreOptionsForm_UndoQueueSizeLabeledIntegerEdit_Text = "������ ������� ������";
            s.CoreOptionsForm_ResultCountMaxLabeledIntegerEdit_Text = "������������ ���������� �����������";
            s.CoreOptionsForm_IgnoreFrameWidthLabeledComboBox_Text = "������ ������������ ����� ��������";

            s.CoreOptionsForm_HighlightTabPage_Text = "���������";
            s.CoreOptionsForm_HighlightDifferenceCheckBox_Text = "��������� ��������";
            s.CoreOptionsForm_DifrentValue_Text = "�������� ��������";
            s.CoreOptionsForm_NotHighlightIfFragmentsMoreThemCheckBox_Text = "�� ������������ ��������, ���� ���������� ������ ���:";
            s.CoreOptionsForm_MaxFragmentsForDisableHighlightLabeledIntegerEdit_Text = "����������� ���������� ���������� ��� ���������� ���������";
            s.CoreOptionsForm_HighlightAllDifferencesCheckBox_Text = "������������ ��� ��������";
            s.CoreOptionsForm_MaxFragmentsForHighlightLabeledIntegerEdit_Text = "����������� ���������� ���������� ��� ���������";
            s.CoreOptionsForm_AmountOfFragmentsOnXLabeledIntegerEdit_Text = "���������� ���������� �� X";
            s.CoreOptionsForm_AmountOfFragmentsOnYLabeledIntegerEdit_Text = "���������� ���������� �� Y";
            s.CoreOptionsForm_NormalizedSizeOfImageLabeledIntegerEdit_Text = "������������� ������ �����������";
            s.CoreOptionsForm_PenThicknessLabeledIntegerEdit_Text = "������� ����� ���������";

            s.CorePathsForm_Text = "����";
            s.CorePathsForm_SearchTabPage_Text = "������";
            s.CorePathsForm_IgnoreTabPage_Text = "����������";
            s.CorePathsForm_ValidTabPage_Text = "���������";
            s.CorePathsForm_DeleteTabPage_Text = "�������";
            s.CorePathsForm_AddFolderButton_Text = "�������� �������";
            s.CorePathsForm_AddFilesButton_Text = "�������� �����";
            s.CorePathsForm_ChangeButton_Text = "��������";
            s.CorePathsForm_RemoveButton_Text = "������";
            s.CorePathsForm_SearchCheckedListBox_ToolTip_Text = "������������� ������ �������� ����� ������ ������������� ��������� ����������.";

            s.ProgressUtils_Completed = "��������� {0}%";
            s.ProgressUtils_5HoursRemaining = "�������� {0} �����";
            s.ProgressUtils_2HoursRemaining = "�������� {0} ����";
            s.ProgressUtils_5MinutesRemaining = "�������� {0} �����";
            s.ProgressUtils_2MinutesRemaining = "�������� {0} ������";
            s.ProgressUtils_5SecondsRemaining = "�������� {0} ������";

            s.ProgressForm_DeleteDefect = "�������� ����������� �������� � ���������� �����������";
            s.ProgressForm_DeleteFirst = "�������� ������ �������� � ���������� �����������";
            s.ProgressForm_DeleteSecond = "�������� ������ �������� � ���������� �����������";
            s.ProgressForm_DeleteBoth = "�������� ���� ������ �������� � ���������� �����������";
            s.ProgressForm_PerformHint = "�������������� ��������� ���������� �����������";
            s.ProgressForm_Mistake = "������� ���������� ����������� ��� ���������";
            s.ProgressForm_RenameCurrent = "��������������/����������� �����������";
            s.ProgressForm_RefreshResults = "���������� �����������";
            s.ProgressForm_Undo = "������ ��������";
            s.ProgressForm_Redo = "���������� ��������";

            s.SearchExecuterForm_Result = "��������� �����������";
            s.SearchExecuterForm_Search = "�����";
            s.SearchExecuterForm_Stopped = "��������� ������";
            s.SearchExecuterForm_MinimizeToTaskbarButton_Text = "��������";
            s.SearchExecuterForm_MinimizeToSystrayButton_Text = "������� �����";

            s.ResultsPreviewBase_NextButton_ToolTip_Text = "������� � ���������� ����������";
            s.ResultsPreviewBase_PreviousButton_ToolTip_Text = "������� � ����������� ����������";

            s.ResultsPreviewDuplPair_DeleteFirstButton_ToolTip_Text = "������� ������ ��������";
            s.ResultsPreviewDuplPair_DeleteSecondButton_ToolTip_Text = "������� ������ ��������";
            s.ResultsPreviewDuplPair_DeleteBothButton_ToolTip_Text = "������� ��� ��������";
            s.ResultsPreviewDuplPair_RenameFirstToSecondButton_ToolTip_Text = "��������� ������ �������� ������";
            s.ResultsPreviewDuplPair_RenameSecondToFirstButton_ToolTip_Text = "��������� ������ �������� ������";
            s.ResultsPreviewDuplPair_MistakeButton_ToolTip_Text = "�������� ������� ��������� ��� ���������";
            s.ResultsPreviewDuplPair_FirstAllMistakeButton_ToolTip_Text = "Mark all results with the current first picture as a mistake";
            s.ResultsPreviewDuplPair_SecondAllMistakeButton_ToolTip_Text = "Mark all results with the current second picture as a mistake";
            s.ResultsPreviewDuplPair_BothAllMistakeButton_ToolTip_Text = "Mark all results with the current first and second pictures as a mistake";
            s.ResultsPreviewDuplPair_FirstAllEquipmentMistakeButton_ToolTip_Text = "Mark all results with the same equipment as the current first picture as a mistake";
            s.ResultsPreviewDuplPair_SecondAllEquipmentMistakeButton_ToolTip_Text = "Mark all results with the same equipment as the current second picture as a mistake";
            s.ResultsPreviewDuplPair_BothAllEquipmentMistakeButton_ToolTip_Text = "Mark all results with the same equipment as the current first and second pictures as a mistake";

            s.ResultsPreviewDefect_DeleteButton_ToolTip_Text = "������� ��������";
            s.ResultsPreviewDefect_MistakeButton_ToolTip_Text = "�������� ������� ��������� ��� ���������";

            s.ResultRowSetter_DefectIcon_ToolTip_Text = "��������� ��������";
            s.ResultRowSetter_DuplPairIcon_ToolTip_Text = "����������� ���� ��������";

            s.ResultRowSetter_UnknownDefectIcon_ToolTip_Text = "����������� ������";
            s.ResultRowSetter_JpegEndMarkerIsAbsentIcon_ToolTip_Text = "����������� ������ ����� JPEG �����";
            s.ResultRowSetter_blockinessIcon_ToolTip_Text = "������� �����������";
            s.ResultRowSetter_blurringIcon_ToolTip_Text = "�������� �����������";

            s.ResultRowSetter_DeleteDefectIcon_ToolTip_Text = "������� ��������";
            s.ResultRowSetter_DeleteFirstIcon_ToolTip_Text = "������� ������ ��������";
            s.ResultRowSetter_DeleteSecondIcon_ToolTip_Text = "������� ������ ��������";
            s.ResultRowSetter_RenameFirstToSecondIcon_ToolTip_Text = "��������� ������ �������� ������";
            s.ResultRowSetter_RenameSecondToFirstIcon_ToolTip_Text = "��������� ������ �������� ������";

            s.ResultRowSetter_Turn_0_Icon_ToolTip_Text = "��������";
            s.ResultRowSetter_Turn_90_Icon_ToolTip_Text = "���������� �� 90�";
            s.ResultRowSetter_Turn_180_Icon_ToolTip_Text = "���������� �� 180�";
            s.ResultRowSetter_Turn_270_Icon_ToolTip_Text = "���������� �� 270�";
            s.ResultRowSetter_MirrorTurn_0_Icon_ToolTip_Text = "������������� ����������";
            s.ResultRowSetter_MirrorTurn_90_Icon_ToolTip_Text = "������������� ���������� � ���������� �� 90�";
            s.ResultRowSetter_MirrorTurn_180_Icon_ToolTip_Text = "������������� ���������� � ���������� �� 180�";
            s.ResultRowSetter_MirrorTurn_270_Icon_ToolTip_Text = "������������� ���������� � ���������� �� 270�";

            s.ResultsListView_Type_Column_Text = "���";
            s.ResultsListView_Group_Column_Text = "������";
            s.ResultsListView_GroupSize_Column_Text = "������ ������";
            s.ResultsListView_Difference_Column_Text = "��������";
            s.ResultsListView_Defect_Column_Text = "��� �������";
            s.ResultsListView_Transform_Column_Text = "�������������";
            s.ResultsListView_Hint_Column_Text = "������������";

            s.ResultsListView_FileName_Column_Text = "���";
            s.ResultsListView_FileDirectory_Column_Text = "� ��������";
            s.ResultsListView_ImageSize_Column_Text = "�������";
            s.ResultsListView_ImageType_Column_Text = "��� ��������";
            s.ResultsListView_Blockiness_Column_Text = "���������";
            s.ResultsListView_Blurring_Column_Text = "��������";
            s.ResultsListView_FileSize_Column_Text = "������";
            s.ResultsListView_FileTime_Column_Text = "���� ���������";

            s.ResultsListView_FirstFileName_Column_Text = "1: ���";
            s.ResultsListView_FirstFileDirectory_Column_Text = "1: � ��������";
            s.ResultsListView_FirstImageSize_Column_Text = "1: �������";
            s.ResultsListView_FirstImageType_Column_Text = "1: ��� ��������";
            s.ResultsListView_FirstBlockiness_Column_Text = "1: ���������";
            s.ResultsListView_FirstBlurring_Column_Text = "1: ��������";
            s.ResultsListView_FirstFileSize_Column_Text = "1: ������";
            s.ResultsListView_FirstFileTime_Column_Text = "1: ���� ���������";
            s.ResultsListView_SecondFileName_Column_Text = "2: ���";
            s.ResultsListView_SecondFileDirectory_Column_Text = "2: � ��������";
            s.ResultsListView_SecondImageSize_Column_Text = "2: �������";
            s.ResultsListView_SecondImageType_Column_Text = "2: ��� ��������";
            s.ResultsListView_SecondBlockiness_Column_Text = "2: ���������";
            s.ResultsListView_SecondBlurring_Column_Text = "2: ��������";
            s.ResultsListView_SecondFileSize_Column_Text = "2: ������";
            s.ResultsListView_SecondFileTime_Column_Text = "2: ���� ���������";

            s.ResultsListViewContextMenu_DeleteDefectItem_Text = "������� ����������� �������� � ���������� �����������";
            s.ResultsListViewContextMenu_DeleteFirstItem_Text = "������� ������ �������� � ���������� �����������";
            s.ResultsListViewContextMenu_DeleteSecondItem_Text = "������� ������ �������� � ���������� �����������";
            s.ResultsListViewContextMenu_DeleteBothItem_Text = "������� ��� ������ �������� � ���������� �����������";
            s.ResultsListViewContextMenu_RenameFirstToSecondIcon_ToolTip_Text = "��������� ������ �������� ������� � ���������� �����������";
            s.ResultsListViewContextMenu_RenameSecondToFirstIcon_ToolTip_Text = "��������� ������ �������� ������� � ���������� �����������";
            s.ResultsListViewContextMenu_RenameFirstLikeSecondButton_ToolTip_Text = "������������� ������ �������� ��� ������ � ���������� �����������";
            s.ResultsListViewContextMenu_RenameSecondLikeFirstButton_ToolTipText = "������������� ������ �������� ��� ������ � ���������� �����������";
            s.ResultsListViewContextMenu_MoveFirstToSecondButton_ToolTipText = "����������� ������ �������� �� ������ � ���������� �����������";
            s.ResultsListViewContextMenu_MoveSecondToFirstButton_ToolTipText = "����������� ������ �������� � ������� � ���������� �����������";
            s.ResultsListViewContextMenu_MistakeItem_Text = "�������� ���������� ���������� ��� ���������";
            s.ResultsListViewContextMenu_PerformHintItem_Text = "������������� ���������� ���������� ����������";

            s.MainStatusStrip_TotalLabel_Text = "�����: ";
            s.MainStatusStrip_CurrentLabel_Text = "�������: ";
            s.MainStatusStrip_SelectedLabel_Text = "��������: ";

            s.MainMenu_FileMenuItem_Text = "����";
            s.MainMenu_File_OpenProfileMenuItem_Text = "������� ������� ������";
            s.MainMenu_File_SaveProfileAsMenuItem_Text = "��������� ������� ������ ���";
            s.MainMenu_File_LoadProfileOnLoadingMenuItem_Text = "��������� ������� ��� ��������";
            s.MainMenu_File_SaveProfileOnClosingMenuItem_Text = "��������� ������� ��� ��������";
            s.MainMenu_File_ExitMenuItem_Text = "�����";

            s.MainMenu_EditMenuItem_Text = "������";
            s.MainMenu_Edit_UndoMenuItem_Text = "�������� (Ctrl-Z)";
            s.MainMenu_Edit_RedoMenuItem_Text = "��������� (Ctrl-Y)";
            s.MainMenu_Edit_SelectAllMenuItem_Text = "�������� ��� (Ctrl-A)";

            s.MainMenu_ViewMenuItem_Text = "���";
            s.MainMenu_View_ToolMenuItem_Text = "������ ������������";
            s.MainMenu_View_StatusMenuItem_Text = "������ ���������";
            s.MainMenu_View_SelectColumnsMenuItem_Text = "����� ��������";
            s.MainMenu_View_HotKeysMenuItem_Text = "������� �������";
            s.MainMenu_View_StretchSmallImagesMenuItem_Text = "����������� ��������� �����������";
            s.MainMenu_View_ProportionalImageSizeMenuItem_Text = "���������������� ������ ��������";
            s.MainMenu_View_ShowNeighbourImageMenuItem_Text = "���������� �������� �����������";

            s.MainMenu_SearchMenuItem_Text = "�����";
            s.MainMenu_Search_StartMenuItem_Text = "������ �����";
            s.MainMenu_Search_RefreshResultsMenuItem_Text = "�������� ����������";
            s.MainMenu_Search_RefreshImagesMenuItem_Text = "������� ������������ ������ �� ���� ������ � ���������";
            s.MainMenu_Search_PathsMenuItem_Text = "����";
            s.MainMenu_Search_OptionsMenuItem_Text = "�����";
            s.MainMenu_Search_OnePathMenuItem_Text = "���� ���� ������";
            s.MainMenu_Search_UseImageDataBaseMenuItem_Text = "������������ ���� ������ � ���������";
            s.MainMenu_Search_CheckResultsAtLoadingMenuItem_Text = "��������� ���������� ��� ��������";
            s.MainMenu_Search_CheckMistakesAtLoadingMenuItem_Text = "��������� ���� ������ �� ������� ��� ��������";

            s.MainMenu_HelpMenuItem_Text = "�������";
            s.MainMenu_Help_HelpMenuItem_Text = "�������";
            s.MainMenu_Help_AboutProgramMenuItem_Text = "� ���������...";
            s.MainMenu_Help_CheckingForUpdatesMenuItem_Text = "��������� ������� ����������";

            s.MainMenu_NewVersionMenuItem_Text = "����� ������";
            s.MainMenu_NewVersionMenuItem_Tooltip = "AntiDupl.NET-{0} �������� �� �����!";

            s.SelectHotKeysForm_InvalidHotKeyToolTipText = "��� ���������� ������ ��� ������������ ��� ������ �����.";

            s.LanguageMenuItem_Text = "����";

            s.ViewModeMenuItem_Text = "����� ��������� �����������";
            s.ViewModeMenuItem_VerticalPairTableMenuItem_Text = "������� ������������ ���";
            s.ViewModeMenuItem_HorizontalPairTableMenuItem_Text = "������� �������������� ���";
            s.ViewModeMenuItem_GroupedThumbnailsMenuItem_Text = "��������������� ���������";

            s.ImagePreviewContextMenu_CopyPathItem_Text = "����������� ����";
            s.ImagePreviewContextMenu_CopyFileNameItem_Text = "����������� ��� ��������";
            s.ImagePreviewContextMenu_OpenImageItem_Text = "������� ��������";
            s.ImagePreviewContextMenu_OpenFolderItem_Text = "������� ������� � ���������";
            s.ImagePreviewContextMenu_AddToIgnore_Text = "�������� � ������������";
            s.ImagePreviewContextMenu_AddToIgnoreDirectory_Text = "�������� ���������� � ������������";
            s.ImagePreviewContextMenu_RenameImageItem_Text = "������������� ��������";
            s.ImagePreviewContextMenu_RenameImageLikeNeighbour_Text = "������������� �������� ��� ��������";
            s.ImagePreviewContextMenu_MoveImageToNeighbourItem_Text = "����������� �������� � ��������";
            s.ImagePreviewContextMenu_MoveAndRenameImageToNeighbourItem_Text = "����������� � ������������� � ��������";
            s.ImagePreviewContextMenu_MoveGroupToNeighbourItem_Text = "��������� ������ � ����� � ��������";
            s.ImagePreviewContextMenu_RenameGroupAsNeighbourItem_Text = "������������� ����� � ������ ��� �������� ����";

            s.ImagePreviewPanel_EXIF_Text = "EXIF";
            s.ImagePreviewPanel_EXIF_Tooltip_ImageDescription = "��������: ";
            s.ImagePreviewPanel_EXIF_Tooltip_EquipMake = "������������ ������: ";
            s.ImagePreviewPanel_EXIF_Tooltip_EquipModel = "������ ������: ";
            s.ImagePreviewPanel_EXIF_Tooltip_SoftwareUsed = "����������� �����������: ";
            s.ImagePreviewPanel_EXIF_Tooltip_DateTime = "����/�����: ";
            s.ImagePreviewPanel_EXIF_Tooltip_Artist = "�����: ";
            s.ImagePreviewPanel_EXIF_Tooltip_UserComment = "�����������: ";
        }

        static private Strings Create()
        {
            Strings strings = new Strings();
            CopyTo(strings);
            return strings;
        }

        static public Strings Get()
        {
            return m_strings;
        }

        static private Strings m_strings = Create();
    }
}
